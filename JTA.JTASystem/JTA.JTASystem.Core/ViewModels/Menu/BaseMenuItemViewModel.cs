using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class BaseMenuItemViewModel : BaseViewModel
    {

        public MenuItemType MenuItemType { get; set; }

        public MenuDirectoryType DirectoryType { get; set; }

        public BaseViewModel Content { get; set; }

        public List<BaseMenuItemViewModel> Children { get; set; }

        public bool CanExpand => DirectoryType == MenuDirectoryType.Parent;

        public bool IsSelected { get; set; } = false;

        public bool ShowChildren => IsSelected && CanExpand;

        public BaseMenuItemViewModel()
        {
        }

        public void GoToPage()
        {

           // IsSelected = true;

            //TODO: Go to the selected page

        }
    }
}
