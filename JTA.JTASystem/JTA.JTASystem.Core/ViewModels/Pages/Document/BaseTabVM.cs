using System.Collections.Generic;
using System.Windows.Input;

namespace JTA.JTASystem.Core.VMs.Pages.Document
{
    public class BaseTabVM : BaseVM
    {
        public string Header { get; set; }

        public ICommand SelectedCommand { get; set; }

        public bool IsSelected { get; set; } = false;

        public BaseVM Content { get; set; }

       // public List<ICommand> 
    }
}
