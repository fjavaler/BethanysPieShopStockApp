﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.Converters
{
  class DoubleToColorConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      // default value.
      double p = 10;

      if (parameter != null)
      {
        p = Double.Parse(parameter.ToString());
      }

      switch(value)
      {
        case double v when v > p:
          return Color.Gold;
        default:
          return Color.Red;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value;
    }
  }
}
