﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class ResidentDetailsControl : UserControl
    {
        public ResidentDetailsControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ResidentDetailsUI Value
        {
            get { return (ResidentDetailsUI)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        private void facilityCardNumber_Leave(object sender, EventArgs e)
        {
            RequestForAutoSuggest();
        }

        private void RequestForAutoSuggest()
        {
            OnAutoSuggestRequired();
        }

        public event EventHandler AutoSuggestRequired;

        void OnAutoSuggestRequired()
        {
            var handler = AutoSuggestRequired;

            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}
