using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking;
using Magenta.Shared.DesignByContract;
using Ninject.Core;
using Magenta.Shared.UI.WinForms.DataBinding;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    [DefaultBindingProperty("Value")]
    public partial class ResidentView : UserControl
    {
        public ResidentView()
        {
            InitializeComponent();

            ViewModel = new ResidentViewModel();

            DataBinder
                .BindTo<ResidentViewModel>(dataContext)
                .ObjectProperty(vm => vm.IsReadOnly)
                    .ControlProperty(name, n => n.ReadOnly)
                    .ControlProperty(facilityCardNumber, n => n.ReadOnly)
                    .ControlProperty(addressBlockNumber, n => n.ReadOnly)
                    .ControlProperty(unitNumberEditorControl1, n => n.ReadOnly);
        }

        ResidentController _controller;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Inject]
        public ResidentController Controller 
        {
            get { return _controller; }
            set { _controller = value; _controller.ViewModel = ViewModel; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public Resident Value
        {
            get { return ViewModel.Resident; }
            set { ViewModel.Resident = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ResidentViewModel ViewModel
        {
            get { return (ResidentViewModel)dataContext.DataSource; }
            private set { dataContext.DataSource = value; }
        }


        private void facilityCardNumber_Validated(object sender, EventArgs e)
        {
            Controller.AutoSuggestResident();
        }
    }
}
