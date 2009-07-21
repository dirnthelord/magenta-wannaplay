using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class BookingScheduleControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.bookingScheduleGrid = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleGrid();
            this.periodStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.cancelBookingButton);
            this.panel1.Controls.Add(this.addBookingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 32);
            this.panel1.TabIndex = 1;
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.Location = new System.Drawing.Point(106, 6);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(97, 23);
            this.cancelBookingButton.TabIndex = 1;
            this.cancelBookingButton.Text = "Cancel booking";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            this.cancelBookingButton.Click += new System.EventHandler(this.cancelBookingButton_Click);
            // 
            // addBookingButton
            // 
            this.addBookingButton.Location = new System.Drawing.Point(3, 6);
            this.addBookingButton.Name = "addBookingButton";
            this.addBookingButton.Size = new System.Drawing.Size(97, 23);
            this.addBookingButton.TabIndex = 0;
            this.addBookingButton.Text = "Add booking";
            this.addBookingButton.UseVisualStyleBackColor = true;
            this.addBookingButton.Click += new System.EventHandler(this.addBookingButton_Click);
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingScheduleViewModel);
            // 
            // bookingScheduleGrid
            // 
            this.bookingScheduleGrid.AllowUserToAddRows = false;
            this.bookingScheduleGrid.AllowUserToDeleteRows = false;
            this.bookingScheduleGrid.AllowUserToResizeColumns = false;
            this.bookingScheduleGrid.AllowUserToResizeRows = false;
            this.bookingScheduleGrid.AutoGenerateColumns = false;
            this.bookingScheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingScheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodStringDataGridViewTextBoxColumn});
            this.bookingScheduleGrid.DataMember = "BookingSlots";
            this.bookingScheduleGrid.DataSource = this.dataContext;
            this.bookingScheduleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingScheduleGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookingScheduleGrid.Location = new System.Drawing.Point(0, 0);
            this.bookingScheduleGrid.Name = "bookingScheduleGrid";
            this.bookingScheduleGrid.ReadOnly = true;
            this.bookingScheduleGrid.RowHeadersVisible = false;
            this.bookingScheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bookingScheduleGrid.Size = new System.Drawing.Size(509, 287);
            this.bookingScheduleGrid.TabIndex = 0;
            this.bookingScheduleGrid.VirtualMode = true;
            this.bookingScheduleGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.bookingScheduleGrid_CellValueNeeded);
            // 
            // periodStringDataGridViewTextBoxColumn
            // 
            this.periodStringDataGridViewTextBoxColumn.DataPropertyName = "PeriodString";
            this.periodStringDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodStringDataGridViewTextBoxColumn.Name = "periodStringDataGridViewTextBoxColumn";
            this.periodStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodStringDataGridViewTextBoxColumn.Width = 62;
            // 
            // BookingScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingScheduleGrid);
            this.Controls.Add(this.panel1);
            this.Name = "BookingScheduleControl";
            this.Size = new System.Drawing.Size(509, 319);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBookingButton;
        private System.Windows.Forms.Button addBookingButton;
        private BookingScheduleGrid bookingScheduleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodStringDataGridViewTextBoxColumn;
    }
}
