using Magenta.WannaPlay.UI.WinForms.ViewModels;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class WannaPlayMainControl
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
            this._facilityTabs = new System.Windows.Forms.TabControl();
            this._tennisTabPage = new System.Windows.Forms.TabPage();
            this.tennisBookingSchedule = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this._squashTabPage = new System.Windows.Forms.TabPage();
            this.squashBookingSchedule = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dayPicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeCurrentDutyGuard = new System.Windows.Forms.Button();
            this.currentDutyGuard = new System.Windows.Forms.TextBox();
            this.currentDutyGuardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.facilityTypeBookingControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this._facilityTabs.SuspendLayout();
            this._tennisTabPage.SuspendLayout();
            this._squashTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDutyGuardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _facilityTabs
            // 
            this._facilityTabs.Controls.Add(this._tennisTabPage);
            this._facilityTabs.Controls.Add(this._squashTabPage);
            this._facilityTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._facilityTabs.Location = new System.Drawing.Point(0, 10);
            this._facilityTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._facilityTabs.Name = "_facilityTabs";
            this._facilityTabs.SelectedIndex = 0;
            this._facilityTabs.Size = new System.Drawing.Size(512, 528);
            this._facilityTabs.TabIndex = 0;
            // 
            // _tennisTabPage
            // 
            this._tennisTabPage.Controls.Add(this.tennisBookingSchedule);
            this._tennisTabPage.Location = new System.Drawing.Point(4, 25);
            this._tennisTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tennisTabPage.Name = "_tennisTabPage";
            this._tennisTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tennisTabPage.Size = new System.Drawing.Size(504, 499);
            this._tennisTabPage.TabIndex = 1;
            this._tennisTabPage.Text = "Tennis Courts";
            this._tennisTabPage.UseVisualStyleBackColor = true;
            // 
            // tennisBookingSchedule
            // 
            this.tennisBookingSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tennisBookingSchedule.Location = new System.Drawing.Point(4, 4);
            this.tennisBookingSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tennisBookingSchedule.Name = "tennisBookingSchedule";
            this.tennisBookingSchedule.Size = new System.Drawing.Size(496, 491);
            this.tennisBookingSchedule.TabIndex = 0;
            // 
            // _squashTabPage
            // 
            this._squashTabPage.Controls.Add(this.squashBookingSchedule);
            this._squashTabPage.Location = new System.Drawing.Point(4, 25);
            this._squashTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._squashTabPage.Name = "_squashTabPage";
            this._squashTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._squashTabPage.Size = new System.Drawing.Size(504, 499);
            this._squashTabPage.TabIndex = 2;
            this._squashTabPage.Text = "Squash Courts";
            this._squashTabPage.UseVisualStyleBackColor = true;
            // 
            // squashBookingSchedule
            // 
            this.squashBookingSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squashBookingSchedule.Location = new System.Drawing.Point(4, 4);
            this.squashBookingSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.squashBookingSchedule.Name = "squashBookingSchedule";
            this.squashBookingSchedule.Size = new System.Drawing.Size(496, 491);
            this.squashBookingSchedule.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 29);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dayPicker);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 29);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day:";
            // 
            // dayPicker
            // 
            this.dayPicker.CustomFormat = "dd MMM yy";
            this.dayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayPicker.Location = new System.Drawing.Point(37, 1);
            this.dayPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(96, 22);
            this.dayPicker.TabIndex = 0;
            this.dayPicker.ValueChanged += new System.EventHandler(this.dayPicker_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.changeCurrentDutyGuard);
            this.panel3.Controls.Add(this.currentDutyGuard);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(144, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 29);
            this.panel3.TabIndex = 7;
            // 
            // changeCurrentDutyGuard
            // 
            this.changeCurrentDutyGuard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCurrentDutyGuard.AutoSize = true;
            this.changeCurrentDutyGuard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeCurrentDutyGuard.Location = new System.Drawing.Point(218, 0);
            this.changeCurrentDutyGuard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeCurrentDutyGuard.Name = "changeCurrentDutyGuard";
            this.changeCurrentDutyGuard.Size = new System.Drawing.Size(151, 27);
            this.changeCurrentDutyGuard.TabIndex = 1;
            this.changeCurrentDutyGuard.Text = "Change duty guard...";
            this.changeCurrentDutyGuard.UseVisualStyleBackColor = true;
            this.changeCurrentDutyGuard.Click += new System.EventHandler(this.changeCurrentDutyGuard_Click);
            // 
            // currentDutyGuard
            // 
            this.currentDutyGuard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDutyGuard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentDutyGuardBindingSource, "Name", true));
            this.currentDutyGuard.Location = new System.Drawing.Point(63, 1);
            this.currentDutyGuard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentDutyGuard.Name = "currentDutyGuard";
            this.currentDutyGuard.ReadOnly = true;
            this.currentDutyGuard.Size = new System.Drawing.Size(145, 22);
            this.currentDutyGuard.TabIndex = 4;
            // 
            // currentDutyGuardBindingSource
            // 
            this.currentDutyGuardBindingSource.DataMember = "CurrentDutyGuard";
            this.currentDutyGuardBindingSource.DataSource = this.dataContext;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.WannaPlayMainViewModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "On duty:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.facilityTypeBookingControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1780, 832);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // facilityTypeBookingControl1
            // 
            this.facilityTypeBookingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilityTypeBookingControl1.Location = new System.Drawing.Point(6, 6);
            this.facilityTypeBookingControl1.Margin = new System.Windows.Forms.Padding(6);
            this.facilityTypeBookingControl1.Name = "facilityTypeBookingControl1";
            this.facilityTypeBookingControl1.Size = new System.Drawing.Size(1768, 820);
            this.facilityTypeBookingControl1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._facilityTabs);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel4.Size = new System.Drawing.Size(512, 538);
            this.panel4.TabIndex = 1;
            // 
            // WannaPlayMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WannaPlayMainControl";
            this.Size = new System.Drawing.Size(512, 567);
            this._facilityTabs.ResumeLayout(false);
            this._tennisTabPage.ResumeLayout(false);
            this._squashTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDutyGuardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl _facilityTabs;
        private System.Windows.Forms.TabPage _tennisTabPage;
        private System.Windows.Forms.TabPage _squashTabPage;
        private BookingScheduleControl facilityTypeBookingControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dayPicker;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingSource dataContext;
        private BookingScheduleControl tennisBookingSchedule;
        private BookingScheduleControl squashBookingSchedule;
        private System.Windows.Forms.Button changeCurrentDutyGuard;
        private System.Windows.Forms.TextBox currentDutyGuard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource currentDutyGuardBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;


    }
}
