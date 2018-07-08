using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            List<int> result = new List<int>();
                    
            while (true)
            {

                if (command[0] == "Odd" || command[0] == "Even")
                {
                    break;
                }
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(Convert.ToInt32(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(Convert.ToInt32(command[2]), Convert.ToInt32(command[1]));
                }

                command = Console.ReadLine().Split().ToList();
            }

            if (command[0] == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
