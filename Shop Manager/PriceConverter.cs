using System;
using System.Globalization;
using System.Windows.Data;

namespace Shop_Manager
{
    [ValueConversion(typeof(string), typeof(string))]
    public class PriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double price = (double) value;
            CultureInfo pl = new CultureInfo("pl-PL");
            return price.ToString("c", pl);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}