using Magenta.WannaPlay.UI.WinForms.ViewModels;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class BookingEntryEditorControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            this.resident = new Magenta.WannaPlay.UI.WinForms.Controls.ResidentEditorControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resident);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(291, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident";
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Comment", true));
            this.comment.Location = new System.Drawing.Point(0, 159);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(291, 74);
            this.comment.TabIndex = 4;
            this.comment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Booking comment";
            // 
            // bookingDetailsTextBox
            // 
            this.bookingDetailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingDetailsTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.bookingDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "BookingDetails", true));
            this.bookingDetailsTextBox.Location = new System.Drawing.Point(0, 0);
            this.bookingDetailsTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.bookingDetailsTextBox.Name = "bookingDetailsTextBox";
            this.bookingDetailsTextBox.ReadOnly = true;
            this.bookingDetailsTextBox.Size = new System.Drawing.Size(291, 20);
            this.bookingDetailsTextBox.TabIndex = 16;
            this.bookingDetailsTextBox.Text = "";
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.ViewModels.BookingEntryViewModel);
            // 
            // resident
            // 
            this.resident.AutoSize = true;
            this.resident.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resident.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataContext, "Resident", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resident.Location = new System.Drawing.Point(8, 21);
            this.resident.Name = "resident";
            this.resident.Size = new System.Drawing.Size(275, 72);
            this.resident.TabIndex = 0;
            this.resident.AutoSuggestRequired += new System.EventHandler(this.resident_AutoSuggestRequired);
            // 
            // BookingEntryEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingDetailsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookingEntryEditorControl";
            this.Size = new System.Drawing.Size(291, 233);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResidentEditorControl resident;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.RichTextBox bookingDetailsTextBox;
    }
}
