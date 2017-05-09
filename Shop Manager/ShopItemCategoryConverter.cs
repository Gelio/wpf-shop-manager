using System;
using System.Globalization;
using System.Windows.Data;

namespace Shop_Manager
{
    public class ShopItemCategoryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            ShopItemCategory category;
            if (!ShopItemCategory.TryParse((string) value, out category))
                return null;

            return category;
        }
    }
}