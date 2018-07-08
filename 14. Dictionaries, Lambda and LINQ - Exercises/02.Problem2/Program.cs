using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var phonebook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook.Remove(command[1]);
                        phonebook.Add(command[1], command[2]);
                    }
                    else
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                }
                if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        string value;
                        if (phonebook.TryGetValue(command[1], out value))
                        {
                            Console.WriteLine($"{command[1]} -> {value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                if (command[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
