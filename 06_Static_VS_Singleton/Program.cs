// See https://aka.ms/new-console-template for more information
using _06_Static_VS_Singleton;

Console.WriteLine("Hello, World!");



double celcius = 37;
double fahrenhiet = 98.6;

Console.WriteLine("{0} Fahrenhiet converted to Celcius {1}", fahrenhiet, StaticDemo.toCelcius(fahrenhiet));
Console.WriteLine("{0} Celcius converted to Fahrenhiet {1}", celcius, StaticDemo.toFahrenheit(celcius));