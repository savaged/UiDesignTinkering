using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace UiDesignTinkering
{
    class InverseBoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new BooleanToVisibilityConverter().Convert(value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new BooleanToVisibilityConverter().ConvertBack(value, targetType, parameter, culture);
        }
    }
}
