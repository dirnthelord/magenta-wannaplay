using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    partial class AddBookingViewPart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this._remarksPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.residentView = new Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking.ResidentView();
            this.dateTimePeriodViewer = new Magenta.WannaPlay.UI.WinForms.Controls.Viewers.DateTimePeriodViewer();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this._remarksPicture);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comment);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 163);
            this.panel4.TabIndex = 20;
            // 
            // _remarksPicture
            // 
            this._remarksPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Remarks;
            this._remarksPicture.Location = new System.Drawing.Point(2, 5);
            this._remarksPicture.Name = "_remarksPicture";
            this._remarksPicture.Size = new System.Drawing.Size(64, 64);
            this._remarksPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._remarksPicture.TabIndex = 18;
            this._remarksPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Remarks";
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Remarks", true));
            this.comment.Location = new System.Drawing.Point(76, 17);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(302, 144);
            this.comment.TabIndex = 16;
            this.comment.Text = "";
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.Domain.BookingEntry);
            // 
            // residentView
            // 
            this.residentView.Dock = System.Windows.Forms.DockStyle.Top;
            this.residentView.Location = new System.Drawing.Point(0, 72);
            this.residentView.Name = "residentView";
            this.residentView.Size = new System.Drawing.Size(379, 104);
            this.residentView.TabIndex = 19;
            // 
            // dateTimePeriodViewer
            // 
            this.dateTimePeriodViewer.AutoSize = true;
            this.dateTimePeriodViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateTimePeriodViewer.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Period", true));
            this.dateTimePeriodViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePeriodViewer.Location = new System.Drawing.Point(0, 0);
            this.dateTimePeriodViewer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.dateTimePeriodViewer.Name = "dateTimePeriodViewer";
            this.dateTimePeriodViewer.Size = new System.Drawing.Size(379, 72);
            this.dateTimePeriodViewer.TabIndex = 0;
            // 
            // AddBookingViewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.residentView);
            this.Controls.Add(this.dateTimePeriodViewer);
            this.Name = "AddBookingViewPart";
            this.Size = new System.Drawing.Size(379, 339);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.PictureBox _remarksPicture;
        private Magenta.WannaPlay.UI.WinForms.Controls.Viewers.DateTimePeriodViewer dateTimePeriodViewer;
        private ResidentView residentView;
    }
}
