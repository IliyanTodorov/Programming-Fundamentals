namespace _07._Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<ushort> numbers = Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToList();

            numbers.Sort();

            int currentNumber = numbers[0];
            int currentCount = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (currentNumber == numbers[i])
                {
                    currentCount++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {currentCount}");
                    currentCount = 1;
                    currentNumber = numbers[i];
                }
            }
            Console.WriteLine($"{currentNumber} -> {currentCount}");
        }
    }
}
