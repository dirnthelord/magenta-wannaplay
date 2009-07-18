namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class FacilityTypeSelector
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.squashButton = new System.Windows.Forms.ToolStripButton();
            this.badmintonButton = new System.Windows.Forms.ToolStripButton();
            this.tennisButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(133, 345);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // squashButton
            // 
            this.squashButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.squashButton.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Squash;
            this.squashButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.squashButton.Name = "squashButton";
            this.squashButton.Size = new System.Drawing.Size(130, 20);
            this.squashButton.Text = "toolStripButton1";
            // 
            // badmintonButton
            // 
            this.badmintonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.badmintonButton.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Badminton;
            this.badmintonButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.badmintonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.badmintonButton.Name = "badmintonButton";
            this.badmintonButton.Size = new System.Drawing.Size(130, 132);
            this.badmintonButton.Text = "toolStripButton2";
            // 
            // tennisButton
            // 
            this.tennisButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tennisButton.Image = global::Magenta.WannaPlay.UI.WinForms.Properties.Resources.Tennis2;
            this.tennisButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tennisButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tennisButton.Name = "tennisButton";
            this.tennisButton.Size = new System.Drawing.Size(130, 132);
            this.tennisButton.Text = "Tennis";
            this.tennisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FacilityTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "FacilityTypeSelector";
            this.Size = new System.Drawing.Size(459, 345);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton squashButton;
        private System.Windows.Forms.ToolStripButton badmintonButton;
        private System.Windows.Forms.ToolStripButton tennisButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
