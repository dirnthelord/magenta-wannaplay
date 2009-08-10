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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.findBookingButton = new System.Windows.Forms.Button();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.bookingScheduleGrid = new Magenta.WannaPlay.UI.WinForms.Controls.DataGridViewEx();
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
            this.panel1.Controls.Add(this.findBookingButton);
            this.panel1.Controls.Add(this.addBookingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(511, 45);
            this.panel1.TabIndex = 1;
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.dataContext, "CanCancelBooking", true));
            this.cancelBookingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBookingButton.Location = new System.Drawing.Point(109, 14);
            this.cancelBookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(100, 27);
            this.cancelBookingButton.TabIndex = 2;
            this.cancelBookingButton.Text = "Cancel booking";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            this.cancelBookingButton.Click += new System.EventHandler(this.cancelBookingClicked);
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingScheduleViewModel);
            this.dataContext.DataSourceChanged += new System.EventHandler(this.dataContext_DataSourceChanged);
            // 
            // findBookingButton
            // 
            this.findBookingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findBookingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBookingButton.Location = new System.Drawing.Point(407, 14);
            this.findBookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.findBookingButton.Name = "findBookingButton";
            this.findBookingButton.Size = new System.Drawing.Size(100, 27);
            this.findBookingButton.TabIndex = 1;
            this.findBookingButton.Text = "Search";
            this.findBookingButton.UseVisualStyleBackColor = true;
            this.findBookingButton.Click += new System.EventHandler(this.FindBookingClicked);
            // 
            // addBookingButton
            // 
            this.addBookingButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.dataContext, "CanAddBooking", true));
            this.addBookingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookingButton.Location = new System.Drawing.Point(4, 14);
            this.addBookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.addBookingButton.Name = "addBookingButton";
            this.addBookingButton.Size = new System.Drawing.Size(100, 27);
            this.addBookingButton.TabIndex = 0;
            this.addBookingButton.Text = "Add";
            this.addBookingButton.UseVisualStyleBackColor = true;
            this.addBookingButton.Click += new System.EventHandler(this.AddBookingClicked);
            // 
            // bookingScheduleGrid
            // 
            this.bookingScheduleGrid.AllowUserToAddRows = false;
            this.bookingScheduleGrid.AllowUserToDeleteRows = false;
            this.bookingScheduleGrid.AllowUserToResizeColumns = false;
            this.bookingScheduleGrid.AllowUserToResizeRows = false;
            this.bookingScheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingScheduleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingScheduleGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookingScheduleGrid.Location = new System.Drawing.Point(0, 0);
            this.bookingScheduleGrid.Margin = new System.Windows.Forms.Padding(4);
            this.bookingScheduleGrid.Name = "bookingScheduleGrid";
            this.bookingScheduleGrid.ReadOnly = true;
            this.bookingScheduleGrid.RowHeadersVisible = false;
            this.bookingScheduleGrid.RowTemplate.Height = 24;
            this.bookingScheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bookingScheduleGrid.Size = new System.Drawing.Size(511, 407);
            this.bookingScheduleGrid.TabIndex = 0;
            this.bookingScheduleGrid.VirtualMode = true;
            this.bookingScheduleGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.bookingScheduleGrid_CellValueNeeded);
            this.bookingScheduleGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ScheduleGridCellMouseDoubleClicked);
            this.bookingScheduleGrid.SelectionChanging += new System.EventHandler<Magenta.Shared.UI.WinForms.Controls.GridSelectionChangingEventArgs>(this.bookingScheduleGrid_SelectionChanging);
            this.bookingScheduleGrid.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.bookingScheduleGrid_CellToolTipTextNeeded);
            this.bookingScheduleGrid.SelectionChanged += new System.EventHandler(this.bookingScheduleGrid_SelectionChanged);
            // 
            // BookingScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingScheduleGrid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingScheduleControl";
            this.Size = new System.Drawing.Size(511, 452);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findBookingButton;
        private System.Windows.Forms.Button addBookingButton;
        private DataGridViewEx bookingScheduleGrid;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Button cancelBookingButton;
    }
}
