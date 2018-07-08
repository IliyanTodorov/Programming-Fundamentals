using System;
using System.Collections.Generic;

namespace _04.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> output = new Dictionary<string, string>();

            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                string count = Console.ReadLine();



                if (!output.ContainsKey(input))
                {
                    output.Add(input, count);
                }
                else
                {
                    output.Remove(input);
                    output.Add(input, count);
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
