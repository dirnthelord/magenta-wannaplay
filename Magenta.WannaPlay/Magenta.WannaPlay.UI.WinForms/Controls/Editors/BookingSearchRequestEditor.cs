﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    [DefaultBindingProperty("Value")]
    public partial class BookingSearchRequestEditor : UserControl
    {
        public BookingSearchRequestEditor()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookingSearchRequestUI Value
        {
            get { return (BookingSearchRequestUI)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }
    }
}