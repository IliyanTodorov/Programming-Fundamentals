namespace _02._Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var item in numbers)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }
            List<string> result = new List<string>();

            foreach (var num in counts)
            {
                if (num.Value % 2 != 0  )
                {
                    result.Add(num.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
