namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class CancelBookingControl
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
            this.bookingSearchControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.BookingSearchControl();
            this.cancelSelectedBooking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bookingSearchControl1
            // 
            this.bookingSearchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.bookingSearchControl1.Name = "bookingSearchControl1";
            this.bookingSearchControl1.Size = new System.Drawing.Size(580, 437);
            this.bookingSearchControl1.TabIndex = 0;
            // 
            // cancelSelectedBooking
            // 
            this.cancelSelectedBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelSelectedBooking.AutoSize = true;
            this.cancelSelectedBooking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelSelectedBooking.Location = new System.Drawing.Point(435, 119);
            this.cancelSelectedBooking.Name = "cancelSelectedBooking";
            this.cancelSelectedBooking.Size = new System.Drawing.Size(142, 23);
            this.cancelSelectedBooking.TabIndex = 1;
            this.cancelSelectedBooking.Text = "Cancel Selected Bookings";
            this.cancelSelectedBooking.UseVisualStyleBackColor = true;
            this.cancelSelectedBooking.Click += new System.EventHandler(this.cancelSelectedBooking_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 0);
            this.panel1.TabIndex = 2;
            // 
            // CancelBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelSelectedBooking);
            this.Controls.Add(this.bookingSearchControl1);
            this.Controls.Add(this.panel1);
            this.Name = "CancelBookingControl";
            this.Size = new System.Drawing.Size(580, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookingSearchControl bookingSearchControl1;
        private System.Windows.Forms.Button cancelSelectedBooking;
        private System.Windows.Forms.Panel panel1;
    }
}
