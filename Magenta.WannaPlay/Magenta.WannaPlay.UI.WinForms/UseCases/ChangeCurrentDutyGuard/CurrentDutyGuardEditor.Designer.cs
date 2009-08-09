using Magenta.WannaPlay.UI.WinForms.ViewModels;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class CurrentDutyGuardEditor
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
            this.manageDutyGuards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
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
            this.dutyGuards.Location = new System.Drawing.Point(87, 2);
            this.dutyGuards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dutyGuards.Name = "dutyGuards";
            this.dutyGuards.Size = new System.Drawing.Size(85, 21);
            this.dutyGuards.TabIndex = 1;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.CurrentDutyGuardViewModel);
            // 
            // manageDutyGuards
            // 
            this.manageDutyGuards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDutyGuards.AutoSize = true;
            this.manageDutyGuards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manageDutyGuards.Enabled = false;
            this.manageDutyGuards.Location = new System.Drawing.Point(176, 1);
            this.manageDutyGuards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageDutyGuards.Name = "manageDutyGuards";
            this.manageDutyGuards.Size = new System.Drawing.Size(65, 23);
            this.manageDutyGuards.TabIndex = 2;
            this.manageDutyGuards.Text = "Manage...";
            this.manageDutyGuards.UseVisualStyleBackColor = true;
            // 
            // CurrentDutyGuardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manageDutyGuards);
            this.Controls.Add(this.dutyGuards);
            this.Controls.Add(this.label1);
            this.Name = "CurrentDutyGuardControl";
            this.Size = new System.Drawing.Size(240, 24);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dutyGuards;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.Button manageDutyGuards;
    }
}
