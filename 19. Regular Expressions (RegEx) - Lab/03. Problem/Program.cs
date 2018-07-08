using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(0x)?[0-9A-F]+\b";

            var numberMathed = Regex.Matches(input, pattern);

            string[] matchedNumbers = numberMathed
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}
