using System.Collections.Generic;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class BaseDocumentVM : BaseVM
    {
        public Document SelectedDocument { get; set; }

        public List<OrderDetail> SelectedOrderDetails { get; set; }

        public List<Status.DocumentStatus> DocumentStatusList { get; set; }

        public string PaymentStatus { get; set; }

        public ICommand SaveCommand { get; set; }

        public ICommand EditCommand { get; set; }

        public ICommand ReturnedCommand { get; set; }

        
    }
}
