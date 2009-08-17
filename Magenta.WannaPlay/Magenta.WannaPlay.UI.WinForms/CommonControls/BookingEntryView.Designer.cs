using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    partial class BookingEntryView
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
            this._remarksPanel = new System.Windows.Forms.Panel();
            this._remarksPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePeriodViewer = new Magenta.WannaPlay.UI.WinForms.CommonControls.DateTimePeriodViewer();
            this.residentView = new Magenta.WannaPlay.UI.WinForms.CommonControls.ResidentView();
            this._separator2 = new System.Windows.Forms.Panel();
            this._separator1 = new System.Windows.Forms.Panel();
            this._remarksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // _remarksPanel
            // 
            this._remarksPanel.AutoSize = true;
            this._remarksPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._remarksPanel.BackColor = System.Drawing.SystemColors.Control;
            this._remarksPanel.Controls.Add(this._remarksPicture);
            this._remarksPanel.Controls.Add(this.label1);
            this._remarksPanel.Controls.Add(this.comment);
            this._remarksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._remarksPanel.Location = new System.Drawing.Point(0, 192);
            this._remarksPanel.Margin = new System.Windows.Forms.Padding(0);
            this._remarksPanel.Name = "_remarksPanel";
            this._remarksPanel.Size = new System.Drawing.Size(379, 105);
            this._remarksPanel.TabIndex = 1;
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
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Booking.Remarks", true));
            this.comment.Location = new System.Drawing.Point(76, 17);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(302, 86);
            this.comment.TabIndex = 0;
            this.comment.Text = "";
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.CommonControls.BookingEntryViewModel);
            // 
            // dateTimePeriodViewer
            // 
            this.dateTimePeriodViewer.AutoSize = true;
            this.dateTimePeriodViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateTimePeriodViewer.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Booking.Period", true));
            this.dateTimePeriodViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePeriodViewer.Location = new System.Drawing.Point(0, 0);
            this.dateTimePeriodViewer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.dateTimePeriodViewer.Name = "dateTimePeriodViewer";
            this.dateTimePeriodViewer.Size = new System.Drawing.Size(379, 72);
            this.dateTimePeriodViewer.TabIndex = 1;
            // 
            // residentView
            // 
            this.residentView.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Booking.Resident", true));
            this.residentView.Dock = System.Windows.Forms.DockStyle.Top;
            this.residentView.Location = new System.Drawing.Point(0, 80);
            this.residentView.Name = "residentView";
            this.residentView.Size = new System.Drawing.Size(379, 104);
            this.residentView.TabIndex = 0;
            // 
            // _separator2
            // 
            this._separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this._separator2.Location = new System.Drawing.Point(0, 72);
            this._separator2.Name = "_separator2";
            this._separator2.Size = new System.Drawing.Size(379, 8);
            this._separator2.TabIndex = 20;
            // 
            // _separator1
            // 
            this._separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this._separator1.Location = new System.Drawing.Point(0, 184);
            this._separator1.Name = "_separator1";
            this._separator1.Size = new System.Drawing.Size(379, 8);
            this._separator1.TabIndex = 21;
            // 
            // BookingEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._remarksPanel);
            this.Controls.Add(this._separator1);
            this.Controls.Add(this.residentView);
            this.Controls.Add(this._separator2);
            this.Controls.Add(this.dateTimePeriodViewer);
            this.Name = "BookingEntryView";
            this.Size = new System.Drawing.Size(379, 297);
            this._remarksPanel.ResumeLayout(false);
            this._remarksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel _remarksPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.PictureBox _remarksPicture;
        private Magenta.WannaPlay.UI.WinForms.CommonControls.DateTimePeriodViewer dateTimePeriodViewer;
        private ResidentView residentView;
        private System.Windows.Forms.Panel _separator2;
        private System.Windows.Forms.Panel _separator1;
    }
}
