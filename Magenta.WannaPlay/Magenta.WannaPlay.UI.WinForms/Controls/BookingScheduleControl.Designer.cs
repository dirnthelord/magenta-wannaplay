using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.addBookingButton = new System.Windows.Forms.Button();
            this.bookingScheduleGrid = new Magenta.WannaPlay.UI.WinForms.Controls.BookingScheduleGrid();
            this.periodStringColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 29);
            this.panel1.TabIndex = 1;
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBookingButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.dataContext, "CanCancelBooking", true));
            this.cancelBookingButton.Location = new System.Drawing.Point(112, 3);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(97, 23);
            this.cancelBookingButton.TabIndex = 1;
            this.cancelBookingButton.Text = "Cancel booking";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingScheduleViewModel);
            // 
            // addBookingButton
            // 
            this.addBookingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookingButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.dataContext, "CanAddBooking", true));
            this.addBookingButton.Location = new System.Drawing.Point(9, 3);
            this.addBookingButton.Name = "addBookingButton";
            this.addBookingButton.Size = new System.Drawing.Size(97, 23);
            this.addBookingButton.TabIndex = 0;
            this.addBookingButton.Text = "Add booking";
            this.addBookingButton.UseVisualStyleBackColor = true;
            // 
            // bookingScheduleGrid
            // 
            this.bookingScheduleGrid.AllowUserToAddRows = false;
            this.bookingScheduleGrid.AllowUserToDeleteRows = false;
            this.bookingScheduleGrid.AllowUserToResizeColumns = false;
            this.bookingScheduleGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.bookingScheduleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingScheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingScheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodStringColumn});
            this.bookingScheduleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingScheduleGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookingScheduleGrid.Location = new System.Drawing.Point(0, 0);
            this.bookingScheduleGrid.Name = "bookingScheduleGrid";
            this.bookingScheduleGrid.ReadOnly = true;
            this.bookingScheduleGrid.RowHeadersVisible = false;
            this.bookingScheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bookingScheduleGrid.Size = new System.Drawing.Size(212, 181);
            this.bookingScheduleGrid.TabIndex = 0;
            this.bookingScheduleGrid.VirtualMode = true;
            this.bookingScheduleGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.bookingScheduleGrid_CellValueNeeded);
            // 
            // periodStringColumn
            // 
            this.periodStringColumn.DataPropertyName = "PeriodString";
            this.periodStringColumn.Frozen = true;
            this.periodStringColumn.HeaderText = "Period";
            this.periodStringColumn.Name = "periodStringColumn";
            this.periodStringColumn.ReadOnly = true;
            this.periodStringColumn.Width = 62;
            // 
            // BookingScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingScheduleGrid);
            this.Controls.Add(this.panel1);
            this.Name = "BookingScheduleControl";
            this.Size = new System.Drawing.Size(212, 210);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBookingButton;
        private System.Windows.Forms.Button addBookingButton;
        private BookingScheduleGrid bookingScheduleGrid;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodStringColumn;
    }
}
