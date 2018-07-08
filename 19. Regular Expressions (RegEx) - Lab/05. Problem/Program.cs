using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[-]?[\d]+([.]?[\d]*)($|(?=\s))";

            var matched = Regex.Matches(numbers, pattern);

            var matchedNumbers = matched
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}
