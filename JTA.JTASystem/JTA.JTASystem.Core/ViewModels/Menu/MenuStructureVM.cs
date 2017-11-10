using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class MenuStructureVM : BaseVM
    {

        //public static MenuStructureVM Instance => new MenuStructureVM();

        public ICommand SelectItem { get; set; }

        private void SelectItemExecute(object i)
        {
            Select((MenuItemVM)i);
        }

        public List<MenuItemVM> MenuItems { get; set; }

        public MenuItemVM SelectedMenu
        {
            get => MenuItems.LastOrDefault();
            set => Select(value);
        }

        public MenuStructureVM()
        {
            SelectItem = new RelayParameterizedCommand(i => SelectItemExecute(i));
        }

        public void Select(MenuItemVM item)
        {            
            foreach(var menu in MenuItems)
            {
                menu.IsSelected = false;

                if(menu.Children != null)
                    menu.Children.ForEach(i => i.IsSelected = false);
            }

            item.IsSelected = true;
            item.GoToPage();
        }
    }
}
