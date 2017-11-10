using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JTA.JTASystem.Core
{
    public class MenuStructureDesign : MenuStructureVM
    {
        public MenuStructureDesign Instance => new MenuStructureDesign();

        public MenuStructureDesign()
        {
            MenuItems = new List<MenuItemVM>
            {

                new MenuItemVM
                {
                   MenuItemType = MenuItemType.Profile,
                   DirectoryType = MenuDirectoryType.Parent,
                   Content = new ProfileMenuVM
                   {
                       InitialContainerRBG = "3490DC",
                       Initials = "ST",
                       Name = "Sharlyn Tan",
                       Position = "Vice Manager"
                   },

                   Children = new List<MenuItemVM>
                   {
                       new MenuItemVM
                       {
                           MenuItemType = MenuItemType.TextAndIcon,
                           DirectoryType = MenuDirectoryType.Child,
                           Content = new TextIconEntryVM
                           {
                               Label = "Edit Profile"
                           }
                       },

                       new MenuItemVM
                       {
                           MenuItemType = MenuItemType.TextAndIcon,
                           DirectoryType = MenuDirectoryType.Child,
                           Content = new TextIconEntryVM
                           {
                               Label = "Logout"
                           }
                       }

                   }

                },

                new MenuItemVM
                {
                    MenuItemType = MenuItemType.TextAndIcon,
                    DirectoryType = MenuDirectoryType.Child,
                    Content = new TextIconEntryVM
                    {
                        Icon = IconType.Dashboard,
                        Label = "Dashboard"
                    }
                },

                new MenuItemVM
                {
                    MenuItemType = MenuItemType.TextAndIcon,
                    DirectoryType = MenuDirectoryType.Parent,
                    Content = new TextIconEntryVM
                    {
                        Icon = IconType.Files,
                        Label = "Documents"
                    },

                    Children = new List<MenuItemVM>
                    {
                        new MenuItemVM
                       {
                           MenuItemType = MenuItemType.TextAndIcon,
                           DirectoryType = MenuDirectoryType.Child,
                           Content = new TextIconEntryVM
                           {
                               Label = "Purchase Orders"
                           }
                       },

                       new MenuItemVM
                       {
                           MenuItemType = MenuItemType.TextAndIcon,
                           DirectoryType = MenuDirectoryType.Child,
                           Content = new TextIconEntryVM
                           {
                               Label = "Order Slips"
                           }
                       },

                       new MenuItemVM
                       {
                           MenuItemType = MenuItemType.TextAndIcon,
                           DirectoryType = MenuDirectoryType.Child,
                           Content = new TextIconEntryVM
                           {
                               Label = "Sales Invoices"
                           }
                       },

                       new MenuItemVM
                       {
                           MenuItemType = MenuItemType.TextAndIcon,
                           DirectoryType = MenuDirectoryType.Child,
                           Content = new TextIconEntryVM
                           {
                               Label = "Return Slips"
                           }
                       }
                    }
                },

                new MenuItemVM
                {
                    MenuItemType = MenuItemType.TextAndIcon,
                    DirectoryType = MenuDirectoryType.Child,
                    Content = new TextIconEntryVM
                    {
                        Icon = IconType.Cubes,
                        Label = "Inventories"
                    }
                },

                new MenuItemVM
                {
                    MenuItemType = MenuItemType.TextAndIcon,
                    DirectoryType = MenuDirectoryType.Child,
                    Content = new TextIconEntryVM
                    {
                        Icon = IconType.Group,
                        Label = "Stakeholders"
                    }
                },

                new MenuItemVM
                {
                    MenuItemType = MenuItemType.TextAndIcon,
                    DirectoryType = MenuDirectoryType.Child,
                    Content = new TextIconEntryVM
                    {
                        Icon = IconType.Money,
                        Label = "Payments"
                    }
                },

                new MenuItemVM
                {
                    MenuItemType = MenuItemType.TextAndIcon,
                    DirectoryType = MenuDirectoryType.Child,
                    Content = new TextIconEntryVM
                    {
                        Icon = IconType.PieChart,
                        Label = "Reports"
                    }
                }

            };
        }
    }
}
