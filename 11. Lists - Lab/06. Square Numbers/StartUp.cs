namespace _06._Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            List<int> squares = new List<int>(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                double square = Math.Sqrt(currentNumber);

                if (square == (int)square)
                {
                    squares.Add(currentNumber);
                }
            }

            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
