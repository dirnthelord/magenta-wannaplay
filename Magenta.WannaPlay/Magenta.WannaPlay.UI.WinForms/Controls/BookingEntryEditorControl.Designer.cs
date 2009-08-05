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
            this.panel1 = new System.Windows.Forms.Panel();
            this._clockPicture = new System.Windows.Forms.PictureBox();
            this.periodFromTextBox = new System.Windows.Forms.TextBox();
            this.bookingPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.periodForTextBox = new System.Windows.Forms.TextBox();
            this.periodDayTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resident = new Magenta.WannaPlay.UI.WinForms.Controls.ResidentEditorControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this._residentPicture = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this._remarksPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            periodDayLabel = new System.Windows.Forms.Label();
            periodForLabel = new System.Windows.Forms.Label();
            periodFromLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._residentPicture)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // periodDayLabel
            // 
            periodDayLabel.AutoSize = true;
            periodDayLabel.Location = new System.Drawing.Point(74, 3);
            periodDayLabel.Name = "periodDayLabel";
            periodDayLabel.Size = new System.Drawing.Size(26, 13);
            periodDayLabel.TabIndex = 16;
            periodDayLabel.Text = "Day";
            // 
            // periodForLabel
            // 
            periodForLabel.AutoSize = true;
            periodForLabel.Location = new System.Drawing.Point(74, 55);
            periodForLabel.Name = "periodForLabel";
            periodForLabel.Size = new System.Drawing.Size(40, 13);
            periodForLabel.TabIndex = 17;
            periodForLabel.Text = "Length";
            // 
            // periodFromLabel
            // 
            periodFromLabel.AutoSize = true;
            periodFromLabel.Location = new System.Drawing.Point(74, 29);
            periodFromLabel.Name = "periodFromLabel";
            periodFromLabel.Size = new System.Drawing.Size(30, 13);
            periodFromLabel.TabIndex = 18;
            periodFromLabel.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this._clockPicture);
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
            this.panel1.Size = new System.Drawing.Size(315, 83);
            this.panel1.TabIndex = 17;
            // 
            // _clockPicture
            // 
            this._clockPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Clock;
            this._clockPicture.Location = new System.Drawing.Point(0, 3);
            this._clockPicture.Name = "_clockPicture";
            this._clockPicture.Size = new System.Drawing.Size(64, 64);
            this._clockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._clockPicture.TabIndex = 20;
            this._clockPicture.TabStop = false;
            // 
            // periodFromTextBox
            // 
            this.periodFromTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingPeriodBindingSource, "PeriodFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "$hh $tt"));
            this.periodFromTextBox.Location = new System.Drawing.Point(119, 26);
            this.periodFromTextBox.Name = "periodFromTextBox";
            this.periodFromTextBox.ReadOnly = true;
            this.periodFromTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodFromTextBox.TabIndex = 19;
            // 
            // bookingPeriodBindingSource
            // 
            this.bookingPeriodBindingSource.DataMember = "BookingPeriod";
            this.bookingPeriodBindingSource.DataSource = this.dataContext;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingEntryViewModel);
            // 
            // periodForTextBox
            // 
            this.periodForTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodForTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingPeriodBindingSource, "PeriodFor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "$h $hour(s)"));
            this.periodForTextBox.Location = new System.Drawing.Point(119, 52);
            this.periodForTextBox.Name = "periodForTextBox";
            this.periodForTextBox.ReadOnly = true;
            this.periodForTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodForTextBox.TabIndex = 18;
            // 
            // periodDayTextBox
            // 
            this.periodDayTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingPeriodBindingSource, "PeriodDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d MMMM"));
            this.periodDayTextBox.Location = new System.Drawing.Point(119, 0);
            this.periodDayTextBox.Name = "periodDayTextBox";
            this.periodDayTextBox.ReadOnly = true;
            this.periodDayTextBox.Size = new System.Drawing.Size(92, 20);
            this.periodDayTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resident);
            this.groupBox1.Location = new System.Drawing.Point(76, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(237, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident";
            // 
            // resident
            // 
            this.resident.AutoSize = true;
            this.resident.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Resident", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resident.Location = new System.Drawing.Point(8, 21);
            this.resident.Margin = new System.Windows.Forms.Padding(4);
            this.resident.Name = "resident";
            this.resident.Size = new System.Drawing.Size(221, 70);
            this.resident.TabIndex = 0;
            this.resident.AutoSuggestRequired += new System.EventHandler(this.resident_AutoSuggestRequired);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this._residentPicture);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 102);
            this.panel3.TabIndex = 18;
            // 
            // _residentPicture
            // 
            this._residentPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Resident;
            this._residentPicture.Location = new System.Drawing.Point(0, 6);
            this._residentPicture.Name = "_residentPicture";
            this._residentPicture.Size = new System.Drawing.Size(64, 64);
            this._residentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._residentPicture.TabIndex = 4;
            this._residentPicture.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this._remarksPicture);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comment);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 185);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 99);
            this.panel4.TabIndex = 20;
            // 
            // _remarksPicture
            // 
            this._remarksPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Remarks;
            this._remarksPicture.Location = new System.Drawing.Point(2, 5);
            this._remarksPicture.Name = "_remarksPicture";
            this._remarksPicture.Size = new System.Drawing.Size(64, 64);
            this._remarksPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._remarksPicture.TabIndex = 18;
            this._remarksPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Remarks";
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Comment", true));
            this.comment.Location = new System.Drawing.Point(76, 17);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(238, 80);
            this.comment.TabIndex = 16;
            this.comment.Text = "";
            // 
            // BookingEntryEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "BookingEntryEditorControl";
            this.Size = new System.Drawing.Size(315, 284);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._residentPicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox periodFromTextBox;
        private System.Windows.Forms.TextBox periodForTextBox;
        private System.Windows.Forms.TextBox periodDayTextBox;
        private System.Windows.Forms.BindingSource bookingPeriodBindingSource;
        private System.Windows.Forms.PictureBox _clockPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private ResidentEditorControl resident;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox _residentPicture;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.PictureBox _remarksPicture;
    }
}
