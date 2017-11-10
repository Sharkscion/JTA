
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class AutoCompleteComboBoxSubjectVM : BaseAutoCompleteComboBox, ISubject
    {
        private List<IObserver> mObservers;

        public ICommand SelectionChangeCommand { get; set; }

        public AutoCompleteComboBoxSubjectVM()
        {
            mObservers = new List<IObserver>();
            ValidationRules = new List<ValidationRule>();

            SelectionChangeCommand = new RelayParameterizedCommand(i => SelectionChange(i));
            FocusCommand = new RelayCommand(Focus);
        }

        private void SelectionChange(object i)
        {
            SelectedItemId = (int)i;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in mObservers)
                observer.Update(SelectedItemId);
        }

        public void Register(IObserver observer)
        {
            mObservers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            mObservers.Remove(observer);
        }

       
    }
}
