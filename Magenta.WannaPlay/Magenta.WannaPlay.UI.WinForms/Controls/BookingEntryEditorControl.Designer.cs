using Magenta.WannaPlay.UI.WinForms.ViewModels;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class BookingEntryEditorControl
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
            System.Windows.Forms.Label periodDayLabel;
            System.Windows.Forms.Label periodForLabel;
            System.Windows.Forms.Label periodFromLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.periodDayTextBox = new System.Windows.Forms.TextBox();
            this.periodForTextBox = new System.Windows.Forms.TextBox();
            this.periodFromTextBox = new System.Windows.Forms.TextBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.resident = new Magenta.WannaPlay.UI.WinForms.Controls.ResidentEditorControl();
            periodDayLabel = new System.Windows.Forms.Label();
            periodForLabel = new System.Windows.Forms.Label();
            periodFromLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resident);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(214, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident";
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Comment", true));
            this.comment.Location = new System.Drawing.Point(0, 24);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(214, 75);
            this.comment.TabIndex = 4;
            this.comment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Booking comment";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(periodFromLabel);
            this.panel1.Controls.Add(this.periodFromTextBox);
            this.panel1.Controls.Add(periodForLabel);
            this.panel1.Controls.Add(this.periodForTextBox);
            this.panel1.Controls.Add(periodDayLabel);
            this.panel1.Controls.Add(this.periodDayTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel1.Size = new System.Drawing.Size(214, 83);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel2.Size = new System.Drawing.Size(214, 99);
            this.panel2.TabIndex = 18;
            // 
            // periodDayLabel
            // 
            periodDayLabel.AutoSize = true;
            periodDayLabel.Location = new System.Drawing.Point(3, 3);
            periodDayLabel.Name = "periodDayLabel";
            periodDayLabel.Size = new System.Drawing.Size(26, 13);
            periodDayLabel.TabIndex = 16;
            periodDayLabel.Text = "Day";
            // 
            // periodDayTextBox
            // 
            this.periodDayTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "BookingPeriod.PeriodDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d MMMM"));
            this.periodDayTextBox.Location = new System.Drawing.Point(49, 0);
            this.periodDayTextBox.Name = "periodDayTextBox";
            this.periodDayTextBox.ReadOnly = true;
            this.periodDayTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodDayTextBox.TabIndex = 17;
            // 
            // periodForLabel
            // 
            periodForLabel.AutoSize = true;
            periodForLabel.Location = new System.Drawing.Point(3, 55);
            periodForLabel.Name = "periodForLabel";
            periodForLabel.Size = new System.Drawing.Size(40, 13);
            periodForLabel.TabIndex = 17;
            periodForLabel.Text = "Length";
            // 
            // periodForTextBox
            // 
            this.periodForTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodForTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "BookingPeriod.PeriodFor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "$h $hour(s)"));
            this.periodForTextBox.Location = new System.Drawing.Point(49, 52);
            this.periodForTextBox.Name = "periodForTextBox";
            this.periodForTextBox.ReadOnly = true;
            this.periodForTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodForTextBox.TabIndex = 18;
            // 
            // periodFromLabel
            // 
            periodFromLabel.AutoSize = true;
            periodFromLabel.Location = new System.Drawing.Point(3, 29);
            periodFromLabel.Name = "periodFromLabel";
            periodFromLabel.Size = new System.Drawing.Size(30, 13);
            periodFromLabel.TabIndex = 18;
            periodFromLabel.Text = "Time";
            // 
            // periodFromTextBox
            // 
            this.periodFromTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "BookingPeriod.PeriodFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "$hh $tt"));
            this.periodFromTextBox.Location = new System.Drawing.Point(49, 26);
            this.periodFromTextBox.Name = "periodFromTextBox";
            this.periodFromTextBox.ReadOnly = true;
            this.periodFromTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodFromTextBox.TabIndex = 19;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingEntryViewModel);
            // 
            // resident
            // 
            this.resident.AutoSize = true;
            this.resident.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resident.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Resident", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resident.Location = new System.Drawing.Point(8, 21);
            this.resident.Name = "resident";
            this.resident.Size = new System.Drawing.Size(198, 72);
            this.resident.TabIndex = 0;
            this.resident.AutoSuggestRequired += new System.EventHandler(this.resident_AutoSuggestRequired);
            // 
            // BookingEntryEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "BookingEntryEditorControl";
            this.Size = new System.Drawing.Size(214, 283);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResidentEditorControl resident;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox periodFromTextBox;
        private System.Windows.Forms.TextBox periodForTextBox;
        private System.Windows.Forms.TextBox periodDayTextBox;
    }
}
