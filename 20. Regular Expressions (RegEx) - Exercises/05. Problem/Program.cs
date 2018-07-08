using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<start>[A-Za-z]+)([<\|\\])(?<content>.+)[<\|\\](?<end>[A-Za-z]+)";

            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            List<string> words = new List<string>();


            if (Regex.IsMatch(keys, pattern))
            {
                Match matched = Regex.Match(keys, pattern);

                var start = matched.Groups["start"].Value;
                var end = matched.Groups["end"].Value;
                var content = matched.Groups["content"].Value;

                string wordPattern = $@"{start}(.*?){end}";

                if (Regex.IsMatch(text, wordPattern))
                {
                    var operation = Regex.Matches(text, wordPattern);
                    foreach (Match item in operation)
                    {
                        var contentForList = item.Groups[1].Value;
                        words.Add(contentForList);
                    }
                }
                else
                {
                    Console.WriteLine("Empty result");
                }
            }

            Console.WriteLine(string.Join("", words));
        }
    }
}
