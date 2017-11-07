using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class MenuStructureViewModel : BaseViewModel
    {

        //public static MenuStructureViewModel Instance => new MenuStructureViewModel();

        public ICommand SelectItem { get; set; }

        private void SelectItemExecute(object i)
        {
            Select((BaseMenuItemViewModel)i);
        }

        public List<BaseMenuItemViewModel> MenuItems { get; set; }

        public BaseMenuItemViewModel SelectedMenu
        {
            get => MenuItems.LastOrDefault();
            set => Select(value);
        }

        public MenuStructureViewModel()
        {
            SelectItem = new RelayParameterizedCommand(i => SelectItemExecute(i));
        }

        public void Select(BaseMenuItemViewModel item)
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
