﻿using System;
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
using Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public partial class ResidentView : UserControl
    {
        public ResidentView()
        {
            InitializeComponent();
        }

        public ResidentController Controller { get; private set; }

        public void SetContext(ResidentViewModel viewModel, ResidentController controller)
        {
            dataContext.DataSource = RequireArg.NotNull(viewModel);
            Controller = RequireArg.NotNull(controller);
        }
    }
}
