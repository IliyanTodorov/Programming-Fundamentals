using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < arr.Count; i++)
            {
                string current = arr[i].ToString();
                result.Add(ReverseString(current));
                
            }

            int total = result.Sum(x => Convert.ToInt32(x));

            Console.WriteLine(total);
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /*
         int reversed = 0;
         for (int b = 0; b < arr.Count; b++)
            {
                int current = arr[b].ToString().Length;
                for (int i = 0; i < 1; i++)
                {
                    while (arr[i] > 0)
                    {
                        reversed = reversed * 10 + arr[i] % 10;
                        arr[i] = arr[i] / 10;

                    }

                    arr[i] = reversed;
                    reversed = 0;

                    result.Add(arr[b]);
                }



            }
         */
    }
}
