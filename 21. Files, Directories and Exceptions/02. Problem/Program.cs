using System;
using System.IO;
using System.Text;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\02. Problem\Files\input.txt");

            var result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                result.AppendLine($"{i + 1}. {lines[i]}");
            }

            File.WriteAllText(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\02. Problem\Files\output.txt", result.ToString());
        }
    }
}
