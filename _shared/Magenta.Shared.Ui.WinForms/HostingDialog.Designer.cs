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
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(568, 283);
            this.content.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 1;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 283);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Size = new System.Drawing.Size(568, 75);
            this.buttonsPanel.TabIndex = 1;
            // 
            // HostingDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(568, 358);
            this.Controls.Add(this.content);
            this.Controls.Add(this.buttonsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "HostingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HostingDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;


    }
}