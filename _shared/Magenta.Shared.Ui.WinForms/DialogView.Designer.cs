namespace Magenta.Shared.UI.WinForms
{
    partial class DialogView
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
            this._separator = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // _separator
            // 
            this._separator.BackColor = System.Drawing.Color.Silver;
            this._separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._separator.Location = new System.Drawing.Point(0, 252);
            this._separator.Margin = new System.Windows.Forms.Padding(2);
            this._separator.Name = "_separator";
            this._separator.Size = new System.Drawing.Size(345, 2);
            this._separator.TabIndex = 3;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsPanel.ColumnCount = 1;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 254);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Size = new System.Drawing.Size(345, 6);
            this.buttonsPanel.TabIndex = 4;
            // 
            // DialogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._separator);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "DialogView";
            this.Size = new System.Drawing.Size(345, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _separator;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
    }
}
