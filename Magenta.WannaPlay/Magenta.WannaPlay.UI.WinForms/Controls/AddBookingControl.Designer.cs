namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class AddBookingControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.addBooking = new System.Windows.Forms.Button();
            this.bookingEntryEditorControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.BookingEntryEditorControl();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.addBooking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 67);
            this.panel1.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancel.Location = new System.Drawing.Point(221, 17);
            this.cancel.Margin = new System.Windows.Forms.Padding(6);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 44);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // addBooking
            // 
            this.addBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addBooking.Location = new System.Drawing.Point(23, 17);
            this.addBooking.Margin = new System.Windows.Forms.Padding(6);
            this.addBooking.Name = "addBooking";
            this.addBooking.Size = new System.Drawing.Size(150, 44);
            this.addBooking.TabIndex = 0;
            this.addBooking.Text = "Add booking";
            this.addBooking.UseVisualStyleBackColor = true;
            this.addBooking.Click += new System.EventHandler(this.addBooking_Click);
            // 
            // bookingEntryEditorControl1
            // 
            this.bookingEntryEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingEntryEditorControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookingEntryEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.bookingEntryEditorControl1.Margin = new System.Windows.Forms.Padding(12);
            this.bookingEntryEditorControl1.Name = "bookingEntryEditorControl1";
            this.bookingEntryEditorControl1.Size = new System.Drawing.Size(394, 421);
            this.bookingEntryEditorControl1.TabIndex = 0;
            // 
            // AddBookingControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bookingEntryEditorControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddBookingControl";
            this.Size = new System.Drawing.Size(394, 488);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookingEntryEditorControl bookingEntryEditorControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button addBooking;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
