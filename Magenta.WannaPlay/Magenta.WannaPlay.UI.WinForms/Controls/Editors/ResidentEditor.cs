using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    [DefaultBindingProperty("ViewModel")]
    public partial class ResidentEditor : UserControl
    {
        public ResidentEditor()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public ResidentEditorViewModel ViewModel
        {
            get { return dataContext.DataSource as ResidentEditorViewModel; }
            set { dataContext.DataSource = value; }
        }

        private void facilityCardNumber_Validated(object sender, EventArgs e)
        {
            OnAutoSuggestRequired();
        }

        void OnAutoSuggestRequired()
        {
            ViewModel.AutoFill();
        }
    }
}
