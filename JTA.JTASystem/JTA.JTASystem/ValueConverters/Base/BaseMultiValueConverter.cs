using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace JTA.JTASystem
{
    /// <summary>
    /// A base value converter that allows direct XAML usage
    /// </summary>
    public abstract class BaseMultiValueConverter<T> : MarkupExtension, IMultiValueConverter
        where T : class, new()
    {

        private static T MConverter = null;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return MConverter ?? (MConverter = new T());
        }

        public abstract object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);

        public abstract object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
    }
}
