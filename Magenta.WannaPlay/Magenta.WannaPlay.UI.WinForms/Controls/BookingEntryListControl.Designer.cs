using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class BookingEntryListControl
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
            this.bookingEntries = new System.Windows.Forms.DataGridView();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.periodStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentPassNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedByGuardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingEntries
            // 
            this.bookingEntries.AllowUserToAddRows = false;
            this.bookingEntries.AllowUserToDeleteRows = false;
            this.bookingEntries.AllowUserToResizeRows = false;
            this.bookingEntries.AutoGenerateColumns = false;
            this.bookingEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodStringDataGridViewTextBoxColumn,
            this.residentPassNumberDataGridViewTextBoxColumn,
            this.residentNameDataGridViewTextBoxColumn,
            this.residentAddressDataGridViewTextBoxColumn,
            this.bookedByGuardDataGridViewTextBoxColumn});
            this.bookingEntries.DataSource = this.dataContext;
            this.bookingEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingEntries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookingEntries.Location = new System.Drawing.Point(0, 0);
            this.bookingEntries.Name = "bookingEntries";
            this.bookingEntries.ReadOnly = true;
            this.bookingEntries.RowHeadersVisible = false;
            this.bookingEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingEntries.Size = new System.Drawing.Size(566, 310);
            this.bookingEntries.TabIndex = 0;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.Domain.UI.BookingSlotDetailsUI);
            // 
            // periodStringDataGridViewTextBoxColumn
            // 
            this.periodStringDataGridViewTextBoxColumn.DataPropertyName = "PeriodString";
            this.periodStringDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodStringDataGridViewTextBoxColumn.Name = "periodStringDataGridViewTextBoxColumn";
            this.periodStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodStringDataGridViewTextBoxColumn.Width = 62;
            // 
            // residentPassNumberDataGridViewTextBoxColumn
            // 
            this.residentPassNumberDataGridViewTextBoxColumn.DataPropertyName = "ResidentPassNumber";
            this.residentPassNumberDataGridViewTextBoxColumn.HeaderText = "Resident Pass Number";
            this.residentPassNumberDataGridViewTextBoxColumn.Name = "residentPassNumberDataGridViewTextBoxColumn";
            this.residentPassNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.residentPassNumberDataGridViewTextBoxColumn.Width = 95;
            // 
            // residentNameDataGridViewTextBoxColumn
            // 
            this.residentNameDataGridViewTextBoxColumn.DataPropertyName = "ResidentName";
            this.residentNameDataGridViewTextBoxColumn.HeaderText = "Resident Name";
            this.residentNameDataGridViewTextBoxColumn.Name = "residentNameDataGridViewTextBoxColumn";
            this.residentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.residentNameDataGridViewTextBoxColumn.Width = 97;
            // 
            // residentAddressDataGridViewTextBoxColumn
            // 
            this.residentAddressDataGridViewTextBoxColumn.DataPropertyName = "ResidentAddress";
            this.residentAddressDataGridViewTextBoxColumn.HeaderText = "Block & Number";
            this.residentAddressDataGridViewTextBoxColumn.Name = "residentAddressDataGridViewTextBoxColumn";
            this.residentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.residentAddressDataGridViewTextBoxColumn.Width = 99;
            // 
            // bookedByGuardDataGridViewTextBoxColumn
            // 
            this.bookedByGuardDataGridViewTextBoxColumn.DataPropertyName = "BookedByGuard";
            this.bookedByGuardDataGridViewTextBoxColumn.HeaderText = "Booked By Guard";
            this.bookedByGuardDataGridViewTextBoxColumn.Name = "bookedByGuardDataGridViewTextBoxColumn";
            this.bookedByGuardDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookedByGuardDataGridViewTextBoxColumn.Width = 80;
            // 
            // BookingEntryListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingEntries);
            this.Name = "BookingEntryListControl";
            this.Size = new System.Drawing.Size(566, 310);
            ((System.ComponentModel.ISupportInitialize)(this.bookingEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingEntries;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentPassNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedByGuardDataGridViewTextBoxColumn;
    }
}
