using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace GUS.Converters
{
    public class NazwaPoziomToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string nazwaPoziom = value as string;

            switch (nazwaPoziom)
            {
                case "Temat":
                    return Brushes.Green;
                case "Zakres informacyjny":
                    return Brushes.Red;
                case "Dziedzina":
                    return Brushes.Yellow;
                default:
                    return Brushes.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
