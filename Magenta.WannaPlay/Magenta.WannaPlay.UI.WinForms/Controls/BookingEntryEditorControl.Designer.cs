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
            this.periodForTextBox = new System.Windows.Forms.TextBox();
            this.periodDayTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this._residentPicture = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this._remarksPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.resident = new Magenta.WannaPlay.UI.WinForms.Controls.ResidentEditorControl();
            periodDayLabel = new System.Windows.Forms.Label();
            periodForLabel = new System.Windows.Forms.Label();
            periodFromLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingPeriodBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._residentPicture)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // periodDayLabel
            // 
            periodDayLabel.AutoSize = true;
            periodDayLabel.Location = new System.Drawing.Point(98, 4);
            periodDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            periodDayLabel.Name = "periodDayLabel";
            periodDayLabel.Size = new System.Drawing.Size(33, 17);
            periodDayLabel.TabIndex = 16;
            periodDayLabel.Text = "Day";
            // 
            // periodForLabel
            // 
            periodForLabel.AutoSize = true;
            periodForLabel.Location = new System.Drawing.Point(98, 68);
            periodForLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            periodForLabel.Name = "periodForLabel";
            periodForLabel.Size = new System.Drawing.Size(52, 17);
            periodForLabel.TabIndex = 17;
            periodForLabel.Text = "Length";
            // 
            // periodFromLabel
            // 
            periodFromLabel.AutoSize = true;
            periodFromLabel.Location = new System.Drawing.Point(98, 36);
            periodFromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            periodFromLabel.Name = "periodFromLabel";
            periodFromLabel.Size = new System.Drawing.Size(39, 17);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(420, 100);
            this.panel1.TabIndex = 17;
            // 
            // _clockPicture
            // 
            this._clockPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Clock;
            this._clockPicture.Location = new System.Drawing.Point(0, 4);
            this._clockPicture.Name = "_clockPicture";
            this._clockPicture.Size = new System.Drawing.Size(64, 64);
            this._clockPicture.TabIndex = 20;
            this._clockPicture.TabStop = false;
            // 
            // periodFromTextBox
            // 
            this.periodFromTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingPeriodBindingSource, "PeriodFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "$hh $tt"));
            this.periodFromTextBox.Location = new System.Drawing.Point(159, 32);
            this.periodFromTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.periodFromTextBox.Name = "periodFromTextBox";
            this.periodFromTextBox.ReadOnly = true;
            this.periodFromTextBox.Size = new System.Drawing.Size(121, 22);
            this.periodFromTextBox.TabIndex = 19;
            // 
            // bookingPeriodBindingSource
            // 
            this.bookingPeriodBindingSource.DataMember = "BookingPeriod";
            this.bookingPeriodBindingSource.DataSource = this.dataContext;
            // 
            // periodForTextBox
            // 
            this.periodForTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodForTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingPeriodBindingSource, "PeriodFor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "$h $hour(s)"));
            this.periodForTextBox.Location = new System.Drawing.Point(159, 64);
            this.periodForTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.periodForTextBox.Name = "periodForTextBox";
            this.periodForTextBox.ReadOnly = true;
            this.periodForTextBox.Size = new System.Drawing.Size(121, 22);
            this.periodForTextBox.TabIndex = 18;
            // 
            // periodDayTextBox
            // 
            this.periodDayTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.periodDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingPeriodBindingSource, "PeriodDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d MMMM"));
            this.periodDayTextBox.Location = new System.Drawing.Point(159, 0);
            this.periodDayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.periodDayTextBox.Name = "periodDayTextBox";
            this.periodDayTextBox.ReadOnly = true;
            this.periodDayTextBox.Size = new System.Drawing.Size(121, 22);
            this.periodDayTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resident);
            this.groupBox1.Location = new System.Drawing.Point(101, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox1.Size = new System.Drawing.Size(316, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this._residentPicture);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 126);
            this.panel3.TabIndex = 18;
            // 
            // _residentPicture
            // 
            this._residentPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Resident;
            this._residentPicture.Location = new System.Drawing.Point(0, 7);
            this._residentPicture.Name = "_residentPicture";
            this._residentPicture.Size = new System.Drawing.Size(64, 64);
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
            this.panel4.Location = new System.Drawing.Point(0, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 123);
            this.panel4.TabIndex = 20;
            // 
            // _remarksPicture
            // 
            this._remarksPicture.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Remarks;
            this._remarksPicture.Location = new System.Drawing.Point(3, 6);
            this._remarksPicture.Name = "_remarksPicture";
            this._remarksPicture.Size = new System.Drawing.Size(64, 64);
            this._remarksPicture.TabIndex = 18;
            this._remarksPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Remarks";
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Comment", true));
            this.comment.Location = new System.Drawing.Point(101, 21);
            this.comment.Margin = new System.Windows.Forms.Padding(4);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(316, 99);
            this.comment.TabIndex = 16;
            this.comment.Text = "";
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingEntryViewModel);
            // 
            // resident
            // 
            this.resident.AutoSize = true;
            this.resident.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Resident", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resident.Location = new System.Drawing.Point(11, 25);
            this.resident.Margin = new System.Windows.Forms.Padding(5);
            this.resident.Name = "resident";
            this.resident.Size = new System.Drawing.Size(294, 87);
            this.resident.TabIndex = 0;
            this.resident.AutoSuggestRequired += new System.EventHandler(this.resident_AutoSuggestRequired);
            // 
            // BookingEntryEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingEntryEditorControl";
            this.Size = new System.Drawing.Size(420, 349);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingPeriodBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._residentPicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._remarksPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
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
