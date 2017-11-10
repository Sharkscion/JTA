using System.Collections.Generic;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public abstract class AddDocumentPageVM : BaseVM
    {
        public string TitlePage { get; set; }

        public string DocumentTitle { get; set; }

        public bool IsDocumentNumberEditable { get; set; } = false;

        public bool HasError { get; set; } = false;

        public string BackPageLinkLabel { get; set; }

        public ApplicationPage BackPageLink{ get; set; }

        public List<object> Row1PageFields { get; set; }

        public List<object> Row2Col1PageFields { get; set; }

        public List<object> Row2Col2PageFields { get; set; }

        public OrderDetailTableVM OrderDetailTable { get; set; }

        public abstract ICommand AddCommand();

        public abstract ICommand CancelCommand();

        public abstract void ConstructPageFields();
    }
}
