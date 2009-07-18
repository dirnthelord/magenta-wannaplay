using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.Services.Residence;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class WannaPlayMainControl : UserControl
    {
        public WannaPlayMainControl()
        {
            InitializeComponent();
        }

        [Inject]
        public IResidenceManager ResidenceManager { get; set; }
    }
}
