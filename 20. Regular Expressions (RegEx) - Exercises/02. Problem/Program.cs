using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string particularWord = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string pattern = $@"(?<word>\b{particularWord}\b)";

            foreach (string sentence in text)
            {
                var match = Regex.Match(sentence, pattern);

                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
