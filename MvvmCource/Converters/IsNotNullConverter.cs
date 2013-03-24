using System;
using System.Globalization;
using System.Windows.Data;

namespace MvvmCource.Converters
{
   public class IsNotNullConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         return (value != null);
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new InvalidOperationException("IsNotNullConverter can only be used OneWay.");
      }
   }
}