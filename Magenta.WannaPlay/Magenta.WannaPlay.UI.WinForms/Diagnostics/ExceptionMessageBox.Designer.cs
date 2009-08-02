namespace Magenta.WannaPlay.UI.WinForms.Diagnostics
{
    partial class ExceptionMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._okBtn = new System.Windows.Forms.Button();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._panel = new System.Windows.Forms.Panel();
            this._tbErrorMessage = new System.Windows.Forms.RichTextBox();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._btDetails = new System.Windows.Forms.Button();
            this._btSend = new System.Windows.Forms.Button();
            this._btCopy = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _okBtn
            // 
            this._okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okBtn.Location = new System.Drawing.Point(477, 135);
            this._okBtn.Margin = new System.Windows.Forms.Padding(4);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(100, 28);
            this._okBtn.TabIndex = 0;
            this._okBtn.Text = "OK";
            this._okBtn.UseVisualStyleBackColor = true;
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl.Location = new System.Drawing.Point(13, 172);
            this._tabControl.Margin = new System.Windows.Forms.Padding(4);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(567, 0);
            this._tabControl.TabIndex = 3;
            // 
            // _panel
            // 
            this._panel.BackColor = System.Drawing.Color.White;
            this._panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panel.Controls.Add(this._tbErrorMessage);
            this._panel.Controls.Add(this._pictureBox);
            this._panel.Dock = System.Windows.Forms.DockStyle.Top;
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Margin = new System.Windows.Forms.Padding(4);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(593, 121);
            this._panel.TabIndex = 2;
            // 
            // _tbErrorMessage
            // 
            this._tbErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbErrorMessage.BackColor = System.Drawing.Color.White;
            this._tbErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tbErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbErrorMessage.Location = new System.Drawing.Point(104, 15);
            this._tbErrorMessage.Margin = new System.Windows.Forms.Padding(4);
            this._tbErrorMessage.Name = "_tbErrorMessage";
            this._tbErrorMessage.ReadOnly = true;
            this._tbErrorMessage.Size = new System.Drawing.Size(472, 101);
            this._tbErrorMessage.TabIndex = 9;
            this._tbErrorMessage.Text = "Internal application error";
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(16, 15);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(67, 62);
            this._pictureBox.TabIndex = 8;
            this._pictureBox.TabStop = false;
            // 
            // _btDetails
            // 
            this._btDetails.Location = new System.Drawing.Point(16, 135);
            this._btDetails.Margin = new System.Windows.Forms.Padding(4);
            this._btDetails.Name = "_btDetails";
            this._btDetails.Size = new System.Drawing.Size(100, 28);
            this._btDetails.TabIndex = 1;
            this._btDetails.Tag = "0";
            this._btDetails.Text = "Details";
            this._toolTip.SetToolTip(this._btDetails, "Show details");
            this._btDetails.UseVisualStyleBackColor = true;
            this._btDetails.Click += new System.EventHandler(this.DetailsClick);
            // 
            // _btSend
            // 
            this._btSend.Location = new System.Drawing.Point(172, 135);
            this._btSend.Margin = new System.Windows.Forms.Padding(4);
            this._btSend.Name = "_btSend";
            this._btSend.Size = new System.Drawing.Size(40, 28);
            this._btSend.TabIndex = 2;
            this._toolTip.SetToolTip(this._btSend, "Send error message to supported team");
            this._btSend.UseVisualStyleBackColor = true;
            this._btSend.Click += new System.EventHandler(this.SendClick);
            // 
            // _btCopy
            // 
            this._btCopy.Location = new System.Drawing.Point(124, 135);
            this._btCopy.Margin = new System.Windows.Forms.Padding(4);
            this._btCopy.Name = "_btCopy";
            this._btCopy.Size = new System.Drawing.Size(40, 28);
            this._btCopy.TabIndex = 4;
            this._toolTip.SetToolTip(this._btCopy, "Copy error message to clipboard");
            this._btCopy.UseVisualStyleBackColor = true;
            this._btCopy.Click += new System.EventHandler(this.copyClick);
            // 
            // ExceptionMessageBox
            // 
            this.AcceptButton = this._okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 176);
            this.Controls.Add(this._btCopy);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._okBtn);
            this.Controls.Add(this._btSend);
            this.Controls.Add(this._btDetails);
            this.Controls.Add(this._panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 183);
            this.Name = "ExceptionMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception";
            this._panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.Button _btDetails;
        private System.Windows.Forms.Button _btSend;
        private System.Windows.Forms.RichTextBox _tbErrorMessage;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _btCopy;
    }
}