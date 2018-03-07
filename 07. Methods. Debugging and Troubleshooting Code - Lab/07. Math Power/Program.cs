using System;

namespace _07._Math_Power
{
    class Program
    {
        public static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double powOfNums = PowTwoNums(num1, num2);
            Console.WriteLine(powOfNums);

        }
        static double PowTwoNums(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
