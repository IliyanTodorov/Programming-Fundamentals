using System;
using System.IO;
using System.Text;

namespace _04._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers1 = File.ReadAllLines(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\04. Problem\Files\input1.txt");
            var numbers2 = File.ReadAllLines(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\04. Problem\Files\input2.txt");

            var result = new StringBuilder();

            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int b = 0; b < 1; b++)
                {
                    result.AppendLine(numbers1[i]);
                    result.AppendLine(numbers2[i]);
                }
            }

            File.WriteAllText(@"C:\Users\ADMIN\source\repos\21. Files, Directories and Exceptions\04. Problem\Files\output.txt", result.ToString());
        }
    }
}
