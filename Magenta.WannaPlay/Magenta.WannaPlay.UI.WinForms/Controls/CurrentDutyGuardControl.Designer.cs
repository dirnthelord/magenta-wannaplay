using Magenta.WannaPlay.UI.WinForms.ViewModels;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class CurrentDutyGuardControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dutyGuards = new System.Windows.Forms.ComboBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currently on duty";
            // 
            // dutyGuards
            // 
            this.dutyGuards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dutyGuards.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dataContext, "SelectedDutyGuard", true));
            this.dutyGuards.DisplayMember = "Name";
            this.dutyGuards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dutyGuards.FormattingEnabled = true;
            this.dutyGuards.Location = new System.Drawing.Point(185, 3);
            this.dutyGuards.Name = "dutyGuards";
            this.dutyGuards.Size = new System.Drawing.Size(263, 33);
            this.dutyGuards.TabIndex = 1;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.CurrentDutyGuardViewModel);
            // 
            // CurrentDutyGuardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dutyGuards);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CurrentDutyGuardControl";
            this.Size = new System.Drawing.Size(451, 39);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dutyGuards;
        private System.Windows.Forms.BindingSource dataContext;
    }
}
