using System;
using System.Globalization;
using System.Windows;

namespace JTA.JTASystem
{
    public class BooleanToMenuVisibilityConverter : BaseValueConverter<BooleanToMenuVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
