using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static_VS_Singleton
{
    internal static class StaticDemo
    {
        public static double toFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        public static double toCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }
    }
}
