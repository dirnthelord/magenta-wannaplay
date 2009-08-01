namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class FindBookingsControl
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
            this.findBookingsRequestEditorControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.FindBookingsRequestEditorControl();
            this.findBookingsButton = new System.Windows.Forms.Button();
            this.bookingEntryListControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.BookingEntryListControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // findBookingsRequestEditorControl1
            // 
            this.findBookingsRequestEditorControl1.AutoSize = true;
            this.findBookingsRequestEditorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findBookingsRequestEditorControl1.Location = new System.Drawing.Point(3, 3);
            this.findBookingsRequestEditorControl1.Name = "findBookingsRequestEditorControl1";
            this.findBookingsRequestEditorControl1.Size = new System.Drawing.Size(153, 85);
            this.findBookingsRequestEditorControl1.TabIndex = 0;
            // 
            // findBookingsButton
            // 
            this.findBookingsButton.AutoSize = true;
            this.findBookingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findBookingsButton.Location = new System.Drawing.Point(67, 99);
            this.findBookingsButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.findBookingsButton.Name = "findBookingsButton";
            this.findBookingsButton.Size = new System.Drawing.Size(83, 23);
            this.findBookingsButton.TabIndex = 1;
            this.findBookingsButton.Text = "Find bookings";
            this.findBookingsButton.UseVisualStyleBackColor = true;
            // 
            // bookingEntryListControl1
            // 
            this.bookingEntryListControl1.Location = new System.Drawing.Point(0, 24);
            this.bookingEntryListControl1.Name = "bookingEntryListControl1";
            this.bookingEntryListControl1.Size = new System.Drawing.Size(494, 305);
            this.bookingEntryListControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.findBookingsRequestEditorControl1);
            this.panel1.Controls.Add(this.findBookingsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 125);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bookingEntryListControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel2.Size = new System.Drawing.Size(494, 329);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search results";
            // 
            // FindBookingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FindBookingsControl";
            this.Size = new System.Drawing.Size(494, 454);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FindBookingsRequestEditorControl findBookingsRequestEditorControl1;
        private System.Windows.Forms.Button findBookingsButton;
        private BookingEntryListControl bookingEntryListControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
