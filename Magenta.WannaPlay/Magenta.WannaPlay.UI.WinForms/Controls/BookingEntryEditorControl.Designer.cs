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
            this.label4 = new System.Windows.Forms.Label();
            this.dutyGuard = new System.Windows.Forms.ComboBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resident = new Magenta.WannaPlay.UI.WinForms.Controls.ResidentDetailsControl();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.facility = new System.Windows.Forms.ComboBox();
            this.bookingPeriod = new Magenta.WannaPlay.UI.WinForms.Controls.DateTimePeriodControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duty guard";
            // 
            // dutyGuard
            // 
            this.dutyGuard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dutyGuard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dutyGuard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dutyGuard.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dataContext, "SelectedDutyGuard", true));
            this.dutyGuard.DisplayMember = "Name";
            this.dutyGuard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dutyGuard.FormatString = "Name";
            this.dutyGuard.FormattingEnabled = true;
            this.dutyGuard.Location = new System.Drawing.Point(109, 0);
            this.dutyGuard.Margin = new System.Windows.Forms.Padding(6);
            this.dutyGuard.Name = "dutyGuard";
            this.dutyGuard.Size = new System.Drawing.Size(238, 32);
            this.dutyGuard.TabIndex = 0;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingEntryEditorViewModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resident);
            this.groupBox1.Location = new System.Drawing.Point(0, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(347, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident";
            // 
            // resident
            // 
            this.resident.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Resident", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resident.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resident.Location = new System.Drawing.Point(10, 32);
            this.resident.Margin = new System.Windows.Forms.Padding(6);
            this.resident.Name = "resident";
            this.resident.Size = new System.Drawing.Size(327, 124);
            this.resident.TabIndex = 0;
            this.resident.AutoSuggestRequired += new System.EventHandler(this.resident_AutoSuggestRequired);
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Comment", true));
            this.comment.Location = new System.Drawing.Point(0, 371);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(347, 76);
            this.comment.TabIndex = 4;
            this.comment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Booking comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Facility";
            // 
            // facility
            // 
            this.facility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.facility.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.facility.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.facility.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dataContext, "SelectedFacility", true));
            this.facility.DisplayMember = "Name";
            this.facility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facility.FormattingEnabled = true;
            this.facility.Location = new System.Drawing.Point(109, 44);
            this.facility.Margin = new System.Windows.Forms.Padding(6);
            this.facility.Name = "facility";
            this.facility.Size = new System.Drawing.Size(238, 32);
            this.facility.TabIndex = 1;
            // 
            // bookingPeriod
            // 
            this.bookingPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingPeriod.DataBindings.Add(new System.Windows.Forms.Binding("ViewModel", this.dataContext, "BookingPeriod", true));
            this.bookingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookingPeriod.Location = new System.Drawing.Point(0, 88);
            this.bookingPeriod.Margin = new System.Windows.Forms.Padding(6);
            this.bookingPeriod.Name = "bookingPeriod";
            this.bookingPeriod.Size = new System.Drawing.Size(347, 78);
            this.bookingPeriod.TabIndex = 2;
            // 
            // AddBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.facility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bookingPeriod);
            this.Controls.Add(this.dutyGuard);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddBookingControl";
            this.Size = new System.Drawing.Size(347, 447);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dutyGuard;
        private DateTimePeriodControl bookingPeriod;
        private ResidentDetailsControl resident;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox facility;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
