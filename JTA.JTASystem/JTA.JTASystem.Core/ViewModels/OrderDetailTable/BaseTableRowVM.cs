using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class BaseTableRowVM : BaseVM
    {
        public bool IsInEditMode { get; set; } = false;

        public bool IsSelected { get; set; } = false;

        public ICommand SelectedCommand { get; set; }

        public BaseTableRowVM()
        {
            SelectedCommand = new RelayCommand(Selected);
        }

        public void Selected()
        {
            IsSelected ^= true;
        }
    }
}
