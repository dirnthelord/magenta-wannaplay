namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class BookingPeriodControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timePeriodLength = new System.Windows.Forms.ComboBox();
            this.timeFrom = new System.Windows.Forms.ComboBox();
            this.dayPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-5, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // timePeriodLength
            // 
            this.timePeriodLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timePeriodLength.FormattingEnabled = true;
            this.timePeriodLength.Items.AddRange(new object[] {
            "1 hour",
            "2 hours"});
            this.timePeriodLength.Location = new System.Drawing.Point(240, 43);
            this.timePeriodLength.Margin = new System.Windows.Forms.Padding(6);
            this.timePeriodLength.Name = "timePeriodLength";
            this.timePeriodLength.Size = new System.Drawing.Size(109, 33);
            this.timePeriodLength.TabIndex = 2;
            // 
            // timeFrom
            // 
            this.timeFrom.FormattingEnabled = true;
            this.timeFrom.Items.AddRange(new object[] {
            "7 AM",
            "8 AM",
            "9 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "1 PM",
            "2 PM",
            "3 PM",
            "4 PM",
            "5 PM",
            "6 PM",
            "7 PM",
            "8 PM",
            "9 PM",
            "10 PM"});
            this.timeFrom.Location = new System.Drawing.Point(64, 43);
            this.timeFrom.Margin = new System.Windows.Forms.Padding(6);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(115, 33);
            this.timeFrom.TabIndex = 1;
            this.timeFrom.SelectedIndexChanged += new System.EventHandler(this.timeFrom_SelectedIndexChanged);
            // 
            // dayPicker
            // 
            this.dayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dayPicker.CustomFormat = "";
            this.dayPicker.Location = new System.Drawing.Point(64, 0);
            this.dayPicker.Margin = new System.Windows.Forms.Padding(6);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(285, 31);
            this.dayPicker.TabIndex = 0;
            // 
            // BookingPeriodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePeriodLength);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.dayPicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BookingPeriodControl";
            this.Size = new System.Drawing.Size(349, 78);
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
    }
}
