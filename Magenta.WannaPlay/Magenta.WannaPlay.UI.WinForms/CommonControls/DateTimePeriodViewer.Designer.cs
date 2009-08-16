namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    partial class DateTimePeriodViewer
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
            System.Windows.Forms.Label periodFromLabel;
            System.Windows.Forms.Label periodForLabel;
            System.Windows.Forms.Label periodDayLabel;
            this.periodFromTextBox = new System.Windows.Forms.TextBox();
            this.periodForTextBox = new System.Windows.Forms.TextBox();
            this.periodDayTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._clockPicture = new System.Windows.Forms.PictureBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            periodFromLabel = new System.Windows.Forms.Label();
            periodForLabel = new System.Windows.Forms.Label();
            periodDayLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // periodFromLabel
            // 
            periodFromLabel.AutoSize = true;
            periodFromLabel.Location = new System.Drawing.Point(0, 29);
            periodFromLabel.Margin = new System.Windows.Forms.Padding(0);
            periodFromLabel.Name = "periodFromLabel";
            periodFromLabel.Size = new System.Drawing.Size(30, 13);
            periodFromLabel.TabIndex = 25;
            periodFromLabel.Text = "Time";
            // 
            // periodForLabel
            // 
            periodForLabel.AutoSize = true;
            periodForLabel.Location = new System.Drawing.Point(0, 55);
            periodForLabel.Margin = new System.Windows.Forms.Padding(0);
            periodForLabel.Name = "periodForLabel";
            periodForLabel.Size = new System.Drawing.Size(40, 13);
            periodForLabel.TabIndex = 23;
            periodForLabel.Text = "Length";
            // 
            // periodDayLabel
            // 
            periodDayLabel.AutoSize = true;
            periodDayLabel.Location = new System.Drawing.Point(0, 3);
            periodDayLabel.Margin = new System.Windows.Forms.Padding(0);
            periodDayLabel.Name = "periodDayLabel";
            periodDayLabel.Size = new System.Drawing.Size(26, 13);
            periodDayLabel.TabIndex = 21;
            periodDayLabel.Text = "Day";
            // 
            // periodFromTextBox
            // 
            this.periodFromTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "PeriodFrom", true));
            this.periodFromTextBox.Location = new System.Drawing.Point(46, 26);
            this.periodFromTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.periodFromTextBox.Name = "periodFromTextBox";
            this.periodFromTextBox.ReadOnly = true;
            this.periodFromTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodFromTextBox.TabIndex = 1;
            // 
            // periodForTextBox
            // 
            this.periodForTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodForTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "PeriodFor", true));
            this.periodForTextBox.Location = new System.Drawing.Point(46, 52);
            this.periodForTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.periodForTextBox.Name = "periodForTextBox";
            this.periodForTextBox.ReadOnly = true;
            this.periodForTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodForTextBox.TabIndex = 2;
            // 
            // periodDayTextBox
            // 
            this.periodDayTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "PeriodDay", true));
            this.periodDayTextBox.Location = new System.Drawing.Point(46, 0);
            this.periodDayTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.periodDayTextBox.Name = "periodDayTextBox";
            this.periodDayTextBox.ReadOnly = true;
            this.periodDayTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodDayTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.periodDayTextBox);
            this.panel1.Controls.Add(periodDayLabel);
            this.panel1.Controls.Add(this.periodForTextBox);
            this.panel1.Controls.Add(periodForLabel);
            this.panel1.Controls.Add(this.periodFromTextBox);
            this.panel1.Controls.Add(periodFromLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(72, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 72);
            this.panel1.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._clockPicture, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 72);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // _clockPicture
            // 
            this._clockPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._clockPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Clock;
            this._clockPicture.Location = new System.Drawing.Point(0, 4);
            this._clockPicture.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this._clockPicture.Name = "_clockPicture";
            this._clockPicture.Size = new System.Drawing.Size(64, 64);
            this._clockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._clockPicture.TabIndex = 27;
            this._clockPicture.TabStop = false;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.CommonControls.DateTimePeriodViewModel);
            // 
            // DateTimePeriodViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DateTimePeriodViewer";
            this.Size = new System.Drawing.Size(210, 72);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _clockPicture;
        private System.Windows.Forms.TextBox periodFromTextBox;
        private System.Windows.Forms.TextBox periodForTextBox;
        private System.Windows.Forms.TextBox periodDayTextBox;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
