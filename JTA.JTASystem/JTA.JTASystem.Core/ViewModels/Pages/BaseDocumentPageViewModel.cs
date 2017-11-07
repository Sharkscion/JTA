
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class BaseDocumentPageViewModel
    {
        public ObservableCollection<BaseDocumentViewModel> Documents { get; set; }
        public List<ICommand> Buttons { get; set; }
        public ICommand SearchCommand { get; set; }
        public Dictionary<string, string> FilterAttributes{ get; set; }
        public Dictionary<string, string> SortByAttributes { get; set; }

    }
}
