using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JTA.JTASystem.Core
{
    public class MainPageDesign : MainPageViewModel
    {
        public MainPageDesign()
        {
            SideNavigationMenu = new MenuStructureViewModel
            {
                MenuItems = new List<BaseMenuItemViewModel>
                {

                    new BaseMenuItemViewModel
                    {
                       MenuItemType = MenuItemType.Profile,
                       DirectoryType = MenuDirectoryType.Parent,
                       Content = new ProfileMenuViewModel
                       {
                           InitialContainerRBG = "3490DC",
                           Initials = "ST",
                           Name = "Sharlyn Tan",
                           Position = "Vice Manager"
                       },

                       Children = new List<BaseMenuItemViewModel>
                       {
                           new BaseMenuItemViewModel
                           {
                               MenuItemType = MenuItemType.TextAndIcon,
                               DirectoryType = MenuDirectoryType.Child,
                               Content = new TextIconMenuViewModel
                               {
                                   Label = "Edit Profile"
                               }
                           },

                           new BaseMenuItemViewModel
                           {
                               MenuItemType = MenuItemType.TextAndIcon,
                               DirectoryType = MenuDirectoryType.Child,
                               Content = new TextIconMenuViewModel
                               {
                                   Label = "Logout"
                               }
                           }

                       }

                    },

                    new BaseMenuItemViewModel
                    {
                        MenuItemType = MenuItemType.TextAndIcon,
                        DirectoryType = MenuDirectoryType.Child,
                        Content = new TextIconMenuViewModel
                        {
                            Icon = IconType.Dashboard,
                            Label = "Dashboard"
                        }
                    },

                    new BaseMenuItemViewModel
                    {
                        MenuItemType = MenuItemType.TextAndIcon,
                        DirectoryType = MenuDirectoryType.Parent,
                        Content = new TextIconMenuViewModel
                        {
                            Icon = IconType.Files,
                            Label = "Documents"
                        },

                        Children = new List<BaseMenuItemViewModel>
                        {
                            new BaseMenuItemViewModel
                           {
                               MenuItemType = MenuItemType.TextAndIcon,
                               DirectoryType = MenuDirectoryType.Child,
                               Content = new TextIconMenuViewModel
                               {
                                   Label = "Purchase Orders"
                               }
                           },

                           new BaseMenuItemViewModel
                           {
                               MenuItemType = MenuItemType.TextAndIcon,
                               DirectoryType = MenuDirectoryType.Child,
                               Content = new TextIconMenuViewModel
                               {
                                   Label = "Order Slips"
                               }
                           },

                           new BaseMenuItemViewModel
                           {
                               MenuItemType = MenuItemType.TextAndIcon,
                               DirectoryType = MenuDirectoryType.Child,
                               Content = new TextIconMenuViewModel
                               {
                                   Label = "Sales Invoices"
                               }
                           },

                           new BaseMenuItemViewModel
                           {
                               MenuItemType = MenuItemType.TextAndIcon,
                               DirectoryType = MenuDirectoryType.Child,
                               Content = new TextIconMenuViewModel
                               {
                                   Label = "Return Slips"
                               }
                           }
                        }
                    },

                    new BaseMenuItemViewModel
                    {
                        MenuItemType = MenuItemType.TextAndIcon,
                        DirectoryType = MenuDirectoryType.Child,
                        Content = new TextIconMenuViewModel
                        {
                            Icon = IconType.Cubes,
                            Label = "Inventories"
                        }
                    },

                    new BaseMenuItemViewModel
                    {
                        MenuItemType = MenuItemType.TextAndIcon,
                        DirectoryType = MenuDirectoryType.Child,
                        Content = new TextIconMenuViewModel
                        {
                            Icon = IconType.Group,
                            Label = "Stakeholders"
                        }
                    },

                    new BaseMenuItemViewModel
                    {
                        MenuItemType = MenuItemType.TextAndIcon,
                        DirectoryType = MenuDirectoryType.Child,
                        Content = new TextIconMenuViewModel
                        {
                            Icon = IconType.Money,
                            Label = "Payments"
                        }
                    },

                    new BaseMenuItemViewModel
                    {
                        MenuItemType = MenuItemType.TextAndIcon,
                        DirectoryType = MenuDirectoryType.Child,
                        Content = new TextIconMenuViewModel
                        {
                            Icon = IconType.PieChart,
                            Label = "Reports"
                        }
                    }

                }
            };
       
        }
    }
}
