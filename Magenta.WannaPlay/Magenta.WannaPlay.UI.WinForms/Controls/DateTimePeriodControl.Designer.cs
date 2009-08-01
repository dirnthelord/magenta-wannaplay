using Magenta.WannaPlay.UI.WinForms.Domain.UI;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class DateTimePeriodControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timePeriodLength = new System.Windows.Forms.ComboBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.timeFrom = new System.Windows.Forms.ComboBox();
            this.dayPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // timePeriodLength
            // 
            this.timePeriodLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timePeriodLength.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dataContext, "PeriodFor", true));
            this.timePeriodLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timePeriodLength.FormattingEnabled = true;
            this.timePeriodLength.Items.AddRange(new object[] {
            "1 hour",
            "2 hours"});
            this.timePeriodLength.Location = new System.Drawing.Point(142, 26);
            this.timePeriodLength.Name = "timePeriodLength";
            this.timePeriodLength.Size = new System.Drawing.Size(83, 21);
            this.timePeriodLength.TabIndex = 2;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.Domain.UI.DateTimePeriodUI);
            // 
            // timeFrom
            // 
            this.timeFrom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dataContext, "PeriodFrom", true));
            this.timeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeFrom.FormattingEnabled = true;
            this.timeFrom.Location = new System.Drawing.Point(33, 26);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(78, 21);
            this.timeFrom.TabIndex = 1;
            // 
            // dayPicker
            // 
            this.dayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dayPicker.CausesValidation = false;
            this.dayPicker.CustomFormat = "";
            this.dayPicker.Location = new System.Drawing.Point(33, 0);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(192, 20);
            this.dayPicker.TabIndex = 0;
            this.dayPicker.ValueChanged += new System.EventHandler(this.dayPicker_ValueChanged);
            // 
            // DateTimePeriodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePeriodLength);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.dayPicker);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DateTimePeriodControl";
            this.Size = new System.Drawing.Size(225, 49);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timePeriodLength;
        private System.Windows.Forms.ComboBox timeFrom;
        private System.Windows.Forms.DateTimePicker dayPicker;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
