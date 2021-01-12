using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Weather.ValueConterters
{
    public class WeatherIconNameToLocalName : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                string val = (value as string);
                if (!string.IsNullOrWhiteSpace(val))
                    return $"https://openweathermap.org/img/wn/{val}@2x.png";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
