namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    partial class AddBookingView
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
            this.bookingEntryView = new Magenta.WannaPlay.UI.WinForms.CommonControls.BookingEntryView();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.addBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingEntryView
            // 
            this.bookingEntryView.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Booking", true));
            this.bookingEntryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingEntryView.Location = new System.Drawing.Point(0, 0);
            this.bookingEntryView.Name = "bookingEntryView";
            this.bookingEntryView.Size = new System.Drawing.Size(380, 301);
            this.bookingEntryView.TabIndex = 5;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking.AddBookingViewModel);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.addBooking);
            this.panel1.Controls.Add(this.cancelAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.panel1.Size = new System.Drawing.Size(380, 40);
            this.panel1.TabIndex = 6;
            // 
            // cancelAdd
            // 
            this.cancelAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelAdd.AutoSize = true;
            this.cancelAdd.Location = new System.Drawing.Point(265, 6);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(104, 23);
            this.cancelAdd.TabIndex = 0;
            this.cancelAdd.Text = "Don\'t add booking";
            this.cancelAdd.UseVisualStyleBackColor = true;
            this.cancelAdd.Click += new System.EventHandler(this.cancelAdd_Click);
            // 
            // addBooking
            // 
            this.addBooking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addBooking.AutoSize = true;
            this.addBooking.Location = new System.Drawing.Point(182, 6);
            this.addBooking.Name = "addBooking";
            this.addBooking.Size = new System.Drawing.Size(77, 23);
            this.addBooking.TabIndex = 1;
            this.addBooking.Text = "Add booking";
            this.addBooking.UseVisualStyleBackColor = true;
            this.addBooking.Click += new System.EventHandler(this.addBooking_Click);
            // 
            // AddBookingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingEntryView);
            this.Controls.Add(this.panel1);
            this.Name = "AddBookingView";
            this.Size = new System.Drawing.Size(380, 341);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Magenta.WannaPlay.UI.WinForms.CommonControls.BookingEntryView bookingEntryView;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBooking;
        private System.Windows.Forms.Button cancelAdd;
    }
}
