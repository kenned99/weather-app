using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Weather.ValueConterters
{
    public class FirstLetterUppercase : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string val && !string.IsNullOrWhiteSpace(val))
                return val[0].ToString().ToUpper() + val.Substring(1);                

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
