using System;
using System.IO;
using System.Text;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\01. Problem\Files\input.txt");

            var result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.AppendLine(lines[i]);
                }
            }

            File.WriteAllText(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\01. Problem\Files\output.txt", result.ToString());
        }
    }
}
