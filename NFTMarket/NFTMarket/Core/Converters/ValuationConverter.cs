using System;
using System.Globalization;
using Xamarin.Forms;

namespace NFTMarket.Core.Converters
{
    public class ValuationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valuation = double.Parse(value.ToString());

            if (valuation < 0)
                return "Red";

            return "#00CA48";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
