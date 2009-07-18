using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using System.Windows.Forms;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class FacilityBookingControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodDataGridViewTextBoxColumn,
            this.bookedByDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.residentNameDataGridViewTextBoxColumn,
            this.facilityCardDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.slotsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // slotsBindingSource
            // 
            this.slotsBindingSource.DataMember = "Slots";
            this.slotsBindingSource.DataSource = this.dataContext;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.FacilityBookingViewModel);
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // bookedByDataGridViewTextBoxColumn
            // 
            this.bookedByDataGridViewTextBoxColumn.DataPropertyName = "BookedBy";
            this.bookedByDataGridViewTextBoxColumn.HeaderText = "Booked By";
            this.bookedByDataGridViewTextBoxColumn.Name = "bookedByDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Block & Unit";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // residentNameDataGridViewTextBoxColumn
            // 
            this.residentNameDataGridViewTextBoxColumn.DataPropertyName = "ResidentName";
            this.residentNameDataGridViewTextBoxColumn.HeaderText = "Resident Name";
            this.residentNameDataGridViewTextBoxColumn.Name = "residentNameDataGridViewTextBoxColumn";
            // 
            // facilityCardDataGridViewTextBoxColumn
            // 
            this.facilityCardDataGridViewTextBoxColumn.DataPropertyName = "FacilityCard";
            this.facilityCardDataGridViewTextBoxColumn.HeaderText = "Facility Card";
            this.facilityCardDataGridViewTextBoxColumn.Name = "facilityCardDataGridViewTextBoxColumn";
            // 
            // FacilityBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "FacilityBookingControl";
            this.Size = new System.Drawing.Size(750, 316);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.BindingSource slotsBindingSource;
        private DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn residentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn facilityCardDataGridViewTextBoxColumn;
    }
}
