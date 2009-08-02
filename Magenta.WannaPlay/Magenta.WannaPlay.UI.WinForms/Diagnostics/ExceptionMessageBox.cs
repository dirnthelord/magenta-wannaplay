using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.Exceptions;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.Diagnostics
{
    /// <summary>
    ///  Shows information about exception. To preview detailed information, 
    /// register implementation IParseException in TraceException property
    /// </summary>
    public partial class ExceptionMessageBox : Form
    {
        #region Constants

        private const string DefaultCaption = "Unexpected error";

        private const int TabsHeight = 350;

        #endregion

        #region Fields

        private bool _showDetails = true;

        private Exception _exception;

        #endregion

        #region Public properties

        public string PathToLogs { get; set; }

        [Inject]
        public ApplicationInfo ApplicationInfo { get; set; }

        [Inject]
        public IExceptionNotifier EmailExceptionNotifier { get; set; }

        #endregion

        #region Ctor

        public ExceptionMessageBox()
        {
            InitializeComponent();
            _pictureBox.Image = Resources.Error.ToBitmap();
            _btCopy.Image = Resources.Copy.ToBitmap();
            _btSend.Image = Resources.EMail.ToBitmap();
        }

        #endregion

        #region Public methods

        public DialogResult ShowDialog(Exception ex)
        {
            _exception = RequireArg.NotNull(ex);

            Text = DefaultCaption;
            Reset();

            _exception.EnumarateExceptions().ForEach(x => AddException(x));

            ShowDetails(false);

            _tbErrorMessage.Text = ex is UserFriendlyException
                ? ex.Message : _tbErrorMessage.Text = string.Format("{0} has encountered an unexpected problem.",
                ApplicationInfo.Name);

            return ShowDialog();
        }

        #endregion

        #region UI Handlers

        private void DetailsClick(object sender, EventArgs e)
        {
            ShowDetails(_showDetails);
        }

        private void ShowDetails(bool showDetails)
        {
            _btDetails.Text = showDetails ? "Hide" : "Details";
            MaximizeBox = showDetails;
            Height += showDetails ? TabsHeight : -_tabControl.Height;

            if (!showDetails)
                WindowState = FormWindowState.Normal;

            FormBorderStyle = showDetails ? FormBorderStyle.Sizable : FormBorderStyle.Fixed3D;

            _showDetails = !showDetails;
        }

        private void SendClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!EmailExceptionNotifier.Notify(_exception))
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(string.Format(@"An e-mail agent was not found on the box.
Please send error description to {0} support team:
- copy exception message to clipboard;
- paste it into e-mail and sent to {1}.",
                                        ApplicationInfo.Name,
                                        ApplicationInfo.SupportEMailAddress),
                                                  "Failed to send an e-mail",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void copyClick(object sender, EventArgs args)
        {
            StringBuilder builder = new StringBuilder();

            _exception.EnumarateExceptions().ForEach(e =>
            {
                builder.AppendLine(e.Message);
                builder.AppendLine(e.StackTrace);
                builder.AppendLine();
            });

            Clipboard.SetText(builder.ToString());
        }


        #endregion

        private void AddException(Exception e)
        {
            TabPage tabPage = new TabPage();
            RichTextBox textBox = new RichTextBox();
            int index = _tabControl.Controls.Count;
            _tabControl.SuspendLayout();
            tabPage.SuspendLayout();
            _tabControl.Controls.Add(tabPage);
            // 
            // tabPage
            // 
            tabPage.Controls.Add(textBox);
            tabPage.Location = new System.Drawing.Point(4, 22);
            tabPage.Name = "tabPage" + index;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(325, 245);
            tabPage.TabIndex = index;
            tabPage.Text = e.GetType().Name;
            tabPage.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(e.Message);
            builder.AppendLine();
            builder.AppendLine(e.StackTrace);

            textBox.Location = new System.Drawing.Point(3, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox" + index;
            textBox.Size = new System.Drawing.Size(319, 239);
            textBox.TabIndex = 0;
            textBox.Text = builder.ToString();
            textBox.ReadOnly = true;
            textBox.Dock = DockStyle.Fill;
            textBox.BackColor = Color.White;
            _tabControl.ResumeLayout();
            tabPage.ResumeLayout();
        }

        private void Reset()
        {
            _tabControl.SuspendLayout();
            _tabControl.TabPages.Clear();
            _tabControl.ResumeLayout();
        }
    }
}