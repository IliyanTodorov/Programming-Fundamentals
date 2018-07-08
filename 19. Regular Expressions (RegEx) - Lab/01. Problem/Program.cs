using System;
using System.Text.RegularExpressions;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string regex = @"\b([A-Z][a-z]{2,}) [A-Z][a-z]{2,}\b";

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
