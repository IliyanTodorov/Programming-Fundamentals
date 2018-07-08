using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // (^|(?<=\s)) --> first word or before it must to have whitespace
            string pattern = @"(^|(?<=\s))(?<user>[a-z0-9]+[-_.]?[a-z0-9]*)@(?<host>[a-z]+[-]?[a-z]*\.[a-z]+[-]?[a-z]*)(\.?[a-z]+)*";

            var matchedEmails = Regex.Matches(input, pattern);

            string[] emails = matchedEmails
                .Cast<Match>()
                .Select(e => e.Value)
                .ToArray();

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
