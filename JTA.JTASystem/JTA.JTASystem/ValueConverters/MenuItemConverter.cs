using System;
using System.Globalization;
using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    public class MenuItemConverter : BaseValueConverter<MenuItemConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MenuItemVM baseMenu)
                if(baseMenu.Content is TextIconEntryVM)
                    return new TextIconMenuItemControl { DataContext = baseMenu.Content};
                else if(baseMenu.Content is ProfileMenuVM)
                    return new ProfileMenuItemControl { DataContext = baseMenu.Content };

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
