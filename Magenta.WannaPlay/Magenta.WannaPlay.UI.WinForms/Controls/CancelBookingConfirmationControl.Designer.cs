using Magenta.WannaPlay.UI.WinForms.Controls.Editors;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class CancelBookingConfirmationControl
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
            this.bookingEntry = new Magenta.WannaPlay.UI.WinForms.Controls.Editors.BookingEntryEditor();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingEntry
            // 
            this.bookingEntry.DataBindings.Add(new System.Windows.Forms.Binding("ViewModel", this.dataContext, "BookingUI", true));
            this.bookingEntry.Location = new System.Drawing.Point(0, 0);
            this.bookingEntry.Name = "bookingEntry";
            this.bookingEntry.Size = new System.Drawing.Size(315, 284);
            this.bookingEntry.TabIndex = 0;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.CancelBookingConfirmationViewModel);
            this.dataContext.CurrentChanged += new System.EventHandler(this.dataContext_CurrentChanged);
            // 
            // CancelBookingConfirmationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingEntry);
            this.Name = "CancelBookingConfirmationControl";
            this.Size = new System.Drawing.Size(336, 333);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BookingEntryEditor bookingEntry;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
