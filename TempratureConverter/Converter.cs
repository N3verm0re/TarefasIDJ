using System;
using System.Collections.Generic;
using System.Text;

namespace TempratureConverter
{
    class Converter
    {
        public static double ConvertCelsius(int f)
        {
            double c = (f - 32) * 5 / 9;
            return c;
        }

        public static double ConvertFahrenheit(int c)
        {
            double f = c * 9 / 5 + 32;
            return f;
        }
    }
}
