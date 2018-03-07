using System;

namespace _02._Practice_Floating_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0}\n{1}\n{2}", firstNumber, secondNumber, thirdNumber);
        }
    }
}
