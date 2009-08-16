using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public class ViewBase : UserControl
    {
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Inject]
        public IKernel Kernel
        {
            get { return _kernel; }
            set { _kernel = value; OnKernelChanged(); }
        }
        IKernel _kernel;


        void OnKernelChanged()
        {
            foreach (var child in ChildrenRequiringInjection)
                Kernel.Inject(child);
        }

        protected virtual IEnumerable<Control> ChildrenRequiringInjection
        {
            get { yield break; }
        }
    }
}
