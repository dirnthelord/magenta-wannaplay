namespace Magenta.Shared.UI.WinForms
{
    partial class HostingDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.content = new System.Windows.Forms.Panel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(568, 258);
            this.content.TabIndex = 0;
            // 
            // buttonsTable
            // 
            this.buttonsTable.ColumnCount = 1;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsTable.Location = new System.Drawing.Point(0, 258);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Size = new System.Drawing.Size(568, 100);
            this.buttonsTable.TabIndex = 1;
            // 
            // HostingDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(568, 358);
            this.Controls.Add(this.content);
            this.Controls.Add(this.buttonsTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "HostingDialog";
            this.Text = "HostingDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;


    }
}