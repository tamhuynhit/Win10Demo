using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace IconDemo.Converters
{
    public class StringToSymbolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string str = (string)value;
            return (Symbol)Enum.Parse(typeof(Symbol), str);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
