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

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    [DefaultBindingProperty("Value")]
    public partial class ResidentEditor : UserControl
    {
        public ResidentEditor()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Resident Value
        {
            get { return dataContext.DataSource as Resident; }
            set { dataContext.DataSource = value; }
        }

        private void facilityCardNumber_Validated(object sender, EventArgs e)
        {
            OnAutoSuggestRequired();
        }

        void OnAutoSuggestRequired()
        {
            throw new NotImplementedException();
            //Value.AutoFill();
        }
    }
}
