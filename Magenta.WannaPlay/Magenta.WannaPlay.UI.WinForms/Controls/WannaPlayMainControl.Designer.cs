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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tennisTabPage = new System.Windows.Forms.TabPage();
            this.squashTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeCurrentDutyGuard = new System.Windows.Forms.Button();
            this.currentDutyGuard = new System.Windows.Forms.TextBox();
            this.currentDutyGuardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dayPicker = new System.Windows.Forms.DateTimePicker();
            this.setDayToToday = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tennisBookingSchedule = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.squashBookingSchedule = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.facilityTypeBookingControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.tabControl1.SuspendLayout();
            this.tennisTabPage.SuspendLayout();
            this.squashTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDutyGuardBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tennisTabPage);
            this.tabControl1.Controls.Add(this.squashTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tennisTabPage
            // 
            this.tennisTabPage.Controls.Add(this.tennisBookingSchedule);
            this.tennisTabPage.Location = new System.Drawing.Point(4, 34);
            this.tennisTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.tennisTabPage.Name = "tennisTabPage";
            this.tennisTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.tennisTabPage.Size = new System.Drawing.Size(589, 452);
            this.tennisTabPage.TabIndex = 1;
            this.tennisTabPage.Text = "Tennis";
            this.tennisTabPage.UseVisualStyleBackColor = true;
            // 
            // squashTabPage
            // 
            this.squashTabPage.Controls.Add(this.squashBookingSchedule);
            this.squashTabPage.Location = new System.Drawing.Point(4, 34);
            this.squashTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.squashTabPage.Name = "squashTabPage";
            this.squashTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.squashTabPage.Size = new System.Drawing.Size(589, 452);
            this.squashTabPage.TabIndex = 2;
            this.squashTabPage.Text = "Squash";
            this.squashTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 38);
            this.panel1.TabIndex = 1;
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
            this.panel3.Location = new System.Drawing.Point(291, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 38);
            this.panel3.TabIndex = 7;
            // 
            // changeCurrentDutyGuard
            // 
            this.changeCurrentDutyGuard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCurrentDutyGuard.AutoSize = true;
            this.changeCurrentDutyGuard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeCurrentDutyGuard.Location = new System.Drawing.Point(191, 0);
            this.changeCurrentDutyGuard.Name = "changeCurrentDutyGuard";
            this.changeCurrentDutyGuard.Size = new System.Drawing.Size(115, 35);
            this.changeCurrentDutyGuard.TabIndex = 1;
            this.changeCurrentDutyGuard.Text = "Change...";
            this.changeCurrentDutyGuard.UseVisualStyleBackColor = true;
            this.changeCurrentDutyGuard.Click += new System.EventHandler(this.changeCurrentDutyGuard_Click);
            // 
            // currentDutyGuard
            // 
            this.currentDutyGuard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDutyGuard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentDutyGuardBindingSource, "Name", true));
            this.currentDutyGuard.Location = new System.Drawing.Point(94, 2);
            this.currentDutyGuard.Name = "currentDutyGuard";
            this.currentDutyGuard.ReadOnly = true;
            this.currentDutyGuard.Size = new System.Drawing.Size(91, 31);
            this.currentDutyGuard.TabIndex = 4;
            // 
            // currentDutyGuardBindingSource
            // 
            this.currentDutyGuardBindingSource.DataMember = "CurrentDutyGuard";
            this.currentDutyGuardBindingSource.DataSource = this.dataContext;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "On duty:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dayPicker);
            this.panel2.Controls.Add(this.setDayToToday);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 38);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day:";
            // 
            // dayPicker
            // 
            this.dayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dayPicker.CustomFormat = "dd MMM yy";
            this.dayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayPicker.Location = new System.Drawing.Point(57, 2);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(134, 31);
            this.dayPicker.TabIndex = 0;
            this.dayPicker.ValueChanged += new System.EventHandler(this.dayPicker_ValueChanged);
            // 
            // setDayToToday
            // 
            this.setDayToToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setDayToToday.AutoSize = true;
            this.setDayToToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setDayToToday.Location = new System.Drawing.Point(197, 0);
            this.setDayToToday.Name = "setDayToToday";
            this.setDayToToday.Size = new System.Drawing.Size(82, 35);
            this.setDayToToday.TabIndex = 1;
            this.setDayToToday.Text = "Today";
            this.setDayToToday.UseVisualStyleBackColor = true;
            this.setDayToToday.Click += new System.EventHandler(this.setDayToToday_Click);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tennisBookingSchedule
            // 
            this.tennisBookingSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tennisBookingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tennisBookingSchedule.Location = new System.Drawing.Point(6, 6);
            this.tennisBookingSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.tennisBookingSchedule.Name = "tennisBookingSchedule";
            this.tennisBookingSchedule.Size = new System.Drawing.Size(577, 440);
            this.tennisBookingSchedule.TabIndex = 0;
            // 
            // squashBookingSchedule
            // 
            this.squashBookingSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squashBookingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squashBookingSchedule.Location = new System.Drawing.Point(6, 6);
            this.squashBookingSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.squashBookingSchedule.Name = "squashBookingSchedule";
            this.squashBookingSchedule.Size = new System.Drawing.Size(577, 452);
            this.squashBookingSchedule.TabIndex = 0;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.WannaPlayMainViewModel);
            // 
            // facilityTypeBookingControl1
            // 
            this.facilityTypeBookingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilityTypeBookingControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facilityTypeBookingControl1.Location = new System.Drawing.Point(6, 6);
            this.facilityTypeBookingControl1.Margin = new System.Windows.Forms.Padding(6);
            this.facilityTypeBookingControl1.Name = "facilityTypeBookingControl1";
            this.facilityTypeBookingControl1.Size = new System.Drawing.Size(1768, 820);
            this.facilityTypeBookingControl1.TabIndex = 0;
            // 
            // WannaPlayMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WannaPlayMainControl";
            this.Size = new System.Drawing.Size(597, 528);
            this.tabControl1.ResumeLayout(false);
            this.tennisTabPage.ResumeLayout(false);
            this.squashTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDutyGuardBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tennisTabPage;
        private System.Windows.Forms.TabPage squashTabPage;
        private BookingScheduleControl facilityTypeBookingControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setDayToToday;
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


    }
}
