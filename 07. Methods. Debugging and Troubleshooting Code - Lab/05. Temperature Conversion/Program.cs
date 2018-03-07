using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertFromCelsiusTofahrenheit(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }

        static double ConvertFromCelsiusTofahrenheit(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
