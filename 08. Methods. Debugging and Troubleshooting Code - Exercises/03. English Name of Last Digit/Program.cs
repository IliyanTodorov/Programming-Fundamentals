using System;
using System.Collections.Generic;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            byte digit = (byte)Math.Abs(num % 10);
            Dictionary<int, string> dictionaryDigits = new Dictionary<int, string>
            {
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine",
                [0] = "zero"
            };
            Console.WriteLine(dictionaryDigits[digit]);
        }
    }
}
