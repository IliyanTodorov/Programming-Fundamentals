using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace _02._Memory_View
{
    class Program
    {
        static void Main(string[] args) 
        {
            string result = string.Empty;
            List<string> words = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Visual Studio crash")
                {
                    break;
                }

                result += line + " ";
            }


            string pattern = @"32656 19759 32763 0 (\d+) 0";
            Match match = Regex.Match(result, pattern);

            while (match.Success)
            {
                int width = int.Parse(match.Groups[1].Value);
                string innerPattern = "32656 19759 32763 0 " + width + " 0 ((\\d+ ){" + width + "})";
                Match innerMatch = Regex.Match(result, innerPattern);
                string wholeMatch = innerMatch.Groups[0].Value;
                string word = ReadWord(innerMatch.Groups[1].Value);
                words.Add(word);
                result = result.Replace(wholeMatch, "");
                match = match.NextMatch();
            }

            Console.WriteLine(string.Join("\n", words));
        }

        private static string ReadWord(string text)
        {
            string word = string.Empty;
            string[] token = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string letter in token)
            {
                word += (char)(int.Parse(letter));
            }
            return word;
        }
    }
}