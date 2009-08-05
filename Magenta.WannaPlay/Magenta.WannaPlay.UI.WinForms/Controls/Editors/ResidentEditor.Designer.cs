using Magenta.WannaPlay.UI.WinForms.Domain.UI;
namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    partial class ResidentEditor
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
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressBlockNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.facilityCardNumber = new System.Windows.Forms.TextBox();
            this.unitNumberEditorControl1 = new UnitNumberEditor();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Name", true));
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.dataContext, "IsReadOnly", true));
            this.name.Location = new System.Drawing.Point(41, 52);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(153, 20);
            this.name.TabIndex = 3;
            this.name.Text = "Weis Mei Yunis Semenovich";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Block";
            // 
            // addressBlockNumber
            // 
            this.addressBlockNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "AddressBlockNumber", true));
            this.addressBlockNumber.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.dataContext, "IsReadOnly", true));
            this.addressBlockNumber.Location = new System.Drawing.Point(41, 26);
            this.addressBlockNumber.Name = "addressBlockNumber";
            this.addressBlockNumber.Size = new System.Drawing.Size(39, 20);
            this.addressBlockNumber.TabIndex = 1;
            this.addressBlockNumber.Text = "1398A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Facility card number";
            // 
            // facilityCardNumber
            // 
            this.facilityCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "FactilityCardNumber", true));
            this.facilityCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.dataContext, "IsReadOnly", true));
            this.facilityCardNumber.Location = new System.Drawing.Point(107, 0);
            this.facilityCardNumber.Name = "facilityCardNumber";
            this.facilityCardNumber.Size = new System.Drawing.Size(34, 20);
            this.facilityCardNumber.TabIndex = 0;
            this.facilityCardNumber.Text = "9999";
            this.facilityCardNumber.Validated += new System.EventHandler(this.facilityCardNumber_Validated);
            // 
            // unitNumberEditorControl1
            // 
            this.unitNumberEditorControl1.AutoSize = true;
            this.unitNumberEditorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unitNumberEditorControl1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.dataContext, "IsWritable", true));
            this.unitNumberEditorControl1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "AddressUnitNumber", true));
            this.unitNumberEditorControl1.Location = new System.Drawing.Point(118, 26);
            this.unitNumberEditorControl1.Margin = new System.Windows.Forms.Padding(4);
            this.unitNumberEditorControl1.Name = "unitNumberEditorControl1";
            this.unitNumberEditorControl1.Size = new System.Drawing.Size(35, 20);
            this.unitNumberEditorControl1.TabIndex = 2;
            this.unitNumberEditorControl1.Value = "  -";
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.Domain.UI.ResidentUI);
            // 
            // ResidentEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitNumberEditorControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.name);
            this.Controls.Add(this.facilityCardNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressBlockNumber);
            this.Controls.Add(this.label6);
            this.Name = "ResidentEditorControl";
            this.Size = new System.Drawing.Size(194, 72);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressBlockNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox facilityCardNumber;
        private System.Windows.Forms.BindingSource dataContext;
        private UnitNumberEditor unitNumberEditorControl1;
    }
}
