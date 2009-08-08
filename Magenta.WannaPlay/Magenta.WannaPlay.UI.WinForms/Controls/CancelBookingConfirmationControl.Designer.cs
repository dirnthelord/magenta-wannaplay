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
            this.bookingEntryEditor = new Magenta.WannaPlay.UI.WinForms.Controls.Editors.BookingEntryEditor();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingEntryEditor
            // 
            this.bookingEntryEditor.DataBindings.Add(new System.Windows.Forms.Binding("ViewModel", this.dataContext, "BookingUI", true));
            this.bookingEntryEditor.Location = new System.Drawing.Point(0, 0);
            this.bookingEntryEditor.Name = "bookingEntryEditor";
            this.bookingEntryEditor.Size = new System.Drawing.Size(315, 284);
            this.bookingEntryEditor.TabIndex = 0;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.CancelBookingConfirmationViewModel);
            // 
            // CancelBookingConfirmationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingEntryEditor);
            this.Name = "CancelBookingConfirmationControl";
            this.Size = new System.Drawing.Size(336, 333);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BookingEntryEditor bookingEntryEditor;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
