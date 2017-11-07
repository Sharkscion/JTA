
using System;
using System.Globalization;
using System.Windows.Media;
using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    public class BooleanToSelectedMenuBrushConverter : BaseMultiValueConverter<BooleanToSelectedMenuBrushConverter>
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)values[0] && !(bool)values[1])
                return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{ColorGenerator.Generate(Core.Color.RedLight)}"));
            return Brushes.Transparent;
        }

        public override object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
