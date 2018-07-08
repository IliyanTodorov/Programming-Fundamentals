namespace _03._Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(double.Parse)
                 .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                double firstNumber = numbers[i];
                double secondNumber = numbers[i + 1];

                if (firstNumber == secondNumber)
                {
                    numbers[i] *= 2;
                    numbers.RemoveAt(i + 1);
                    i -= 2;

                    if (i < -1)
                    {
                        i = -1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
