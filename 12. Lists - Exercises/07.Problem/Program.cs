using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _07.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int index = numbers.IndexOf(specialNumbers[0]);

            for (int i = 0; i < 2*specialNumbers[1] + 1; i++)
            {
               // if (numbers.Exists(index - specialNumbers[1] + 1))
                {
                    numbers.RemoveAt(index - specialNumbers[1]);
                }
                //else
                {
                    numbers.RemoveAt(index);
                    break;
                }
            }

            int total = numbers.Sum(x => Convert.ToInt32(x));

            Console.WriteLine(total);

        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
