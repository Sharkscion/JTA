using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class AutoCompleteComboBoxObserverVM : BaseAutoCompleteComboBox, IObserver
    {
        

        public AutoCompleteComboBoxObserverVM()
        {
            ValidationRules = new List<ValidationRule>();
        }

        public void Update(object item = null)
        {
            //TODO: update the list of items displayed
            Label = "Selected Item Id:" + item;
        }
    }
}
