using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\03. Problem\Files\input.txt").ToLower();
            string[] words = File.ReadAllText(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\03. Problem\Files\words.txt").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries) ;
            
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var currentIndex = 0;
                var counter = 0;

                while (true)
                {
                    var foundIndex = text.IndexOf(word, currentIndex);
                    if (foundIndex < 0)
                    {
                        break;
                    }

                    currentIndex = foundIndex + word.Length;

                    var prevIndex = foundIndex - 1;
                    if (prevIndex >= 0 && char.IsLetter(text[prevIndex]))
                    {
                        continue;
                    }

                    var nextIndex = foundIndex + word.Length;
                    if (nextIndex < text.Length && char.IsLetter(text[nextIndex]))
                    {
                        continue;
                    }
                    counter++;

                    
                }

                result[word] = counter;
            }

            var resultText = new StringBuilder();

            foreach (var word in result.OrderByDescending(x => x.Value))
            {
                resultText.AppendLine($"{word.Key} - {word.Value}");
            }

            File.WriteAllText(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\03. Problem\Files\output.txt", resultText.ToString());
        }
    }
}
