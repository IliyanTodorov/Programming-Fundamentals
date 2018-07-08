using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();

            int skip = elements[0];
            int take = elements[1];

            string pattern = @"\|<(\w{" + skip + @"})(\w{0," + take + @"})";

            var matched = Regex.Matches(input, pattern);

            List<string> res = new List<string>();
            foreach (Match m in matched)
            {
                res.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
