namespace _04._Largest_3_Numbers
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

            var sortedNums = numbers.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", sortedNums));
        }
    }
}
