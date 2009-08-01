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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label blockNumberLabel;
            System.Windows.Forms.Label facilityCardNumberLabel;
            System.Windows.Forms.Label unitNumberLabel;
            this.findBookingRequestUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blockNumberTextBox = new System.Windows.Forms.TextBox();
            this.facilityCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.unitNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            blockNumberLabel = new System.Windows.Forms.Label();
            facilityCardNumberLabel = new System.Windows.Forms.Label();
            unitNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.findBookingRequestUIBindingSource)).BeginInit();
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
            // findBookingRequestUIBindingSource
            // 
            this.findBookingRequestUIBindingSource.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.Domain.UI.FindBookingRequestUI);
            // 
            // blockNumberTextBox
            // 
            this.blockNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findBookingRequestUIBindingSource, "BlockNumber", true));
            this.blockNumberTextBox.Location = new System.Drawing.Point(110, 39);
            this.blockNumberTextBox.Name = "blockNumberTextBox";
            this.blockNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.blockNumberTextBox.TabIndex = 3;
            // 
            // facilityCardNumberTextBox
            // 
            this.facilityCardNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findBookingRequestUIBindingSource, "FacilityCardNumber", true));
            this.facilityCardNumberTextBox.Location = new System.Drawing.Point(110, 0);
            this.facilityCardNumberTextBox.Name = "facilityCardNumberTextBox";
            this.facilityCardNumberTextBox.Size = new System.Drawing.Size(62, 20);
            this.facilityCardNumberTextBox.TabIndex = 4;
            // 
            // unitNumberTextBox
            // 
            this.unitNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findBookingRequestUIBindingSource, "UnitNumber", true));
            this.unitNumberTextBox.Location = new System.Drawing.Point(110, 65);
            this.unitNumberTextBox.Name = "unitNumberTextBox";
            this.unitNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitNumberTextBox.TabIndex = 5;
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
            // FindBookingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(unitNumberLabel);
            this.Controls.Add(this.unitNumberTextBox);
            this.Controls.Add(facilityCardNumberLabel);
            this.Controls.Add(this.facilityCardNumberTextBox);
            this.Controls.Add(blockNumberLabel);
            this.Controls.Add(this.blockNumberTextBox);
            this.Name = "FindBookingsControl";
            this.Size = new System.Drawing.Size(305, 195);
            ((System.ComponentModel.ISupportInitialize)(this.findBookingRequestUIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource findBookingRequestUIBindingSource;
        private System.Windows.Forms.TextBox blockNumberTextBox;
        private System.Windows.Forms.TextBox facilityCardNumberTextBox;
        private System.Windows.Forms.TextBox unitNumberTextBox;
        private System.Windows.Forms.Label label1;


    }
}
