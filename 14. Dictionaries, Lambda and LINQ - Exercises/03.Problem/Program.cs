using System;
using System.Collections.Generic;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> output = new Dictionary<string, int>();

            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int count = int.Parse(Console.ReadLine());

                

                if (!output.ContainsKey(input))
                {
                    output.Add(input, 0);   
                }
                output[input] += count;
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
