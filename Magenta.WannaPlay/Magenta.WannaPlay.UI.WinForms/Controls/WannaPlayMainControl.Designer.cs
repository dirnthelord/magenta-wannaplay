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
            this.tennisBookingSchedule = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.squashTabPage = new System.Windows.Forms.TabPage();
            this.squashBookingSchedule = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setDayToToday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dayPicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.facilityTypeBookingControl1 = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleControl();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tennisTabPage.SuspendLayout();
            this.squashTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tennisTabPage);
            this.tabControl1.Controls.Add(this.squashTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 343);
            this.tabControl1.TabIndex = 0;
            // 
            // tennisTabPage
            // 
            this.tennisTabPage.Controls.Add(this.tennisBookingSchedule);
            this.tennisTabPage.Location = new System.Drawing.Point(4, 34);
            this.tennisTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.tennisTabPage.Name = "tennisTabPage";
            this.tennisTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.tennisTabPage.Size = new System.Drawing.Size(778, 305);
            this.tennisTabPage.TabIndex = 1;
            this.tennisTabPage.Text = "Tennis";
            this.tennisTabPage.UseVisualStyleBackColor = true;
            // 
            // tennisBookingSchedule
            // 
            this.tennisBookingSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tennisBookingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tennisBookingSchedule.Location = new System.Drawing.Point(6, 6);
            this.tennisBookingSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.tennisBookingSchedule.Name = "tennisBookingSchedule";
            this.tennisBookingSchedule.Size = new System.Drawing.Size(766, 293);
            this.tennisBookingSchedule.TabIndex = 0;
            // 
            // squashTabPage
            // 
            this.squashTabPage.Controls.Add(this.squashBookingSchedule);
            this.squashTabPage.Location = new System.Drawing.Point(4, 34);
            this.squashTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.squashTabPage.Name = "squashTabPage";
            this.squashTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.squashTabPage.Size = new System.Drawing.Size(778, 305);
            this.squashTabPage.TabIndex = 2;
            this.squashTabPage.Text = "Squash";
            this.squashTabPage.UseVisualStyleBackColor = true;
            // 
            // squashBookingSchedule
            // 
            this.squashBookingSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squashBookingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squashBookingSchedule.Location = new System.Drawing.Point(6, 6);
            this.squashBookingSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.squashBookingSchedule.Name = "squashBookingSchedule";
            this.squashBookingSchedule.Size = new System.Drawing.Size(766, 293);
            this.squashBookingSchedule.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.setDayToToday);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dayPicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 56);
            this.panel1.TabIndex = 1;
            // 
            // setDayToToday
            // 
            this.setDayToToday.Location = new System.Drawing.Point(450, 6);
            this.setDayToToday.Margin = new System.Windows.Forms.Padding(6);
            this.setDayToToday.Name = "setDayToToday";
            this.setDayToToday.Size = new System.Drawing.Size(85, 44);
            this.setDayToToday.TabIndex = 2;
            this.setDayToToday.Text = "Today";
            this.setDayToToday.UseVisualStyleBackColor = true;
            this.setDayToToday.Click += new System.EventHandler(this.setDayToToday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "View schedule for";
            // 
            // dayPicker
            // 
            this.dayPicker.Location = new System.Drawing.Point(202, 13);
            this.dayPicker.Margin = new System.Windows.Forms.Padding(6);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(236, 31);
            this.dayPicker.TabIndex = 0;
            this.dayPicker.ValueChanged += new System.EventHandler(this.dayPicker_ValueChanged);
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
            this.facilityTypeBookingControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facilityTypeBookingControl1.Location = new System.Drawing.Point(6, 6);
            this.facilityTypeBookingControl1.Margin = new System.Windows.Forms.Padding(6);
            this.facilityTypeBookingControl1.Name = "facilityTypeBookingControl1";
            this.facilityTypeBookingControl1.Size = new System.Drawing.Size(1768, 820);
            this.facilityTypeBookingControl1.TabIndex = 0;
            // 
            // WannaPlayMainControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WannaPlayMainControl";
            this.Size = new System.Drawing.Size(786, 399);
            this.Load += new System.EventHandler(this.WannaPlayMainControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tennisTabPage.ResumeLayout(false);
            this.squashTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
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


    }
}
