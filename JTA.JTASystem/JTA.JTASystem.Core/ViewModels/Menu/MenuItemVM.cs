using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class MenuItemVM : BaseVM
    {

        public MenuItemType MenuItemType { get; set; }

        public MenuDirectoryType DirectoryType { get; set; }

        public BaseVM Content { get; set; }

        public List<MenuItemVM> Children { get; set; }

        public bool CanExpand => DirectoryType == MenuDirectoryType.Parent;

        public bool IsSelected { get; set; } = false;

        public bool ShowChildren => IsSelected && CanExpand;

        public MenuItemVM()
        {
        }

        public void GoToPage()
        {

           // IsSelected = true;

            //TODO: Go to the selected page

        }
    }
}
