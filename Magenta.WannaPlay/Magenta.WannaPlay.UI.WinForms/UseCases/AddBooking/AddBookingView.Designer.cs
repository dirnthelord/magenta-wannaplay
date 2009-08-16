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
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingEntryView
            // 
            this.bookingEntryView.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Booking", true));
            this.bookingEntryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingEntryView.Location = new System.Drawing.Point(0, 0);
            this.bookingEntryView.Name = "bookingEntryView";
            this.bookingEntryView.Size = new System.Drawing.Size(380, 291);
            this.bookingEntryView.TabIndex = 5;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking.AddBookingViewModel);
            // 
            // AddBookingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingEntryView);
            this.Name = "AddBookingView";
            this.Size = new System.Drawing.Size(380, 299);
            this.Controls.SetChildIndex(this.bookingEntryView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Magenta.WannaPlay.UI.WinForms.CommonControls.BookingEntryView bookingEntryView;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
