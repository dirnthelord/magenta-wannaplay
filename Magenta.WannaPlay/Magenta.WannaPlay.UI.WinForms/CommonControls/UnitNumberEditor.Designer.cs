namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    partial class UnitNumberEditor
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
            this.unitNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // unitNumber
            // 
            this.unitNumber.Culture = new System.Globalization.CultureInfo("");
            this.unitNumber.Location = new System.Drawing.Point(0, 0);
            this.unitNumber.Margin = new System.Windows.Forms.Padding(0);
            this.unitNumber.Mask = "00-00";
            this.unitNumber.Name = "unitNumber";
            this.unitNumber.Size = new System.Drawing.Size(35, 20);
            this.unitNumber.TabIndex = 20;
            // 
            // UnitNumberEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.unitNumber);
            this.Name = "UnitNumberEditorControl";
            this.Size = new System.Drawing.Size(35, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox unitNumber;
    }
}
