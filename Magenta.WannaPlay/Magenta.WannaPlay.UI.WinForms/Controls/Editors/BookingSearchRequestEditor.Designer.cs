namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    partial class BookingSearchRequestEditor
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
            System.Windows.Forms.Label blockNumberLabel;
            System.Windows.Forms.Label facilityCardNumberLabel;
            System.Windows.Forms.Label unitNumberLabel;
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.blockNumberTextBox = new System.Windows.Forms.TextBox();
            this.facilityCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unitNumberEditorControl1 = new UnitNumberEditor();
            blockNumberLabel = new System.Windows.Forms.Label();
            facilityCardNumberLabel = new System.Windows.Forms.Label();
            unitNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // blockNumberLabel
            // 
            blockNumberLabel.AutoSize = true;
            blockNumberLabel.Location = new System.Drawing.Point(27, 42);
            blockNumberLabel.Name = "blockNumberLabel";
            blockNumberLabel.Size = new System.Drawing.Size(77, 13);
            blockNumberLabel.TabIndex = 2;
            blockNumberLabel.Text = "Block Number:";
            // 
            // facilityCardNumberLabel
            // 
            facilityCardNumberLabel.AutoSize = true;
            facilityCardNumberLabel.Location = new System.Drawing.Point(-3, 3);
            facilityCardNumberLabel.Name = "facilityCardNumberLabel";
            facilityCardNumberLabel.Size = new System.Drawing.Size(107, 13);
            facilityCardNumberLabel.TabIndex = 3;
            facilityCardNumberLabel.Text = "Facility Card Number:";
            // 
            // unitNumberLabel
            // 
            unitNumberLabel.AutoSize = true;
            unitNumberLabel.Location = new System.Drawing.Point(35, 68);
            unitNumberLabel.Name = "unitNumberLabel";
            unitNumberLabel.Size = new System.Drawing.Size(69, 13);
            unitNumberLabel.TabIndex = 4;
            unitNumberLabel.Text = "Unit Number:";
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.Domain.BookingSearchRequest);
            // 
            // blockNumberTextBox
            // 
            this.blockNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Unit.BlockNumber", true));
            this.blockNumberTextBox.Location = new System.Drawing.Point(110, 39);
            this.blockNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.blockNumberTextBox.Name = "blockNumberTextBox";
            this.blockNumberTextBox.Size = new System.Drawing.Size(43, 20);
            this.blockNumberTextBox.TabIndex = 1;
            // 
            // facilityCardNumberTextBox
            // 
            this.facilityCardNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Resident.FacilityCardNumber", true));
            this.facilityCardNumberTextBox.Location = new System.Drawing.Point(110, 0);
            this.facilityCardNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.facilityCardNumberTextBox.Name = "facilityCardNumberTextBox";
            this.facilityCardNumberTextBox.Size = new System.Drawing.Size(43, 20);
            this.facilityCardNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "OR";
            // 
            // unitNumberEditorControl1
            // 
            this.unitNumberEditorControl1.AutoSize = true;
            this.unitNumberEditorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unitNumberEditorControl1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Unit.UnitNumber", true));
            this.unitNumberEditorControl1.Location = new System.Drawing.Point(110, 65);
            this.unitNumberEditorControl1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.unitNumberEditorControl1.Name = "unitNumberEditorControl1";
            this.unitNumberEditorControl1.Size = new System.Drawing.Size(35, 20);
            this.unitNumberEditorControl1.TabIndex = 2;
            this.unitNumberEditorControl1.Value = "  -";
            // 
            // BookingSearchRequestEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.unitNumberEditorControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(unitNumberLabel);
            this.Controls.Add(facilityCardNumberLabel);
            this.Controls.Add(this.facilityCardNumberTextBox);
            this.Controls.Add(blockNumberLabel);
            this.Controls.Add(this.blockNumberTextBox);
            this.Name = "BookingSearchRequestEditorControl";
            this.Size = new System.Drawing.Size(153, 85);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.TextBox blockNumberTextBox;
        private System.Windows.Forms.TextBox facilityCardNumberTextBox;
        private System.Windows.Forms.Label label1;
        private UnitNumberEditor unitNumberEditorControl1;


    }
}
