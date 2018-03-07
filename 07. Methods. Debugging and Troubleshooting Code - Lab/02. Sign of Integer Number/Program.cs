using System;

namespace _02._Sign_of_Integer_Number
{
    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
