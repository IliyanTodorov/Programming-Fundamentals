using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            bool isRunning = true;
            while (isRunning)
            {
                string[] tokens = Console.ReadLine().ToLower().Split(' ').ToArray();

                for (int i = 0; i < tokens.Length - 1; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string item = tokens[i + 1];

                    if (keyMaterials.ContainsKey(item))
                    {
                        keyMaterials[item] += quantity;

                        if (keyMaterials[item] >= 250)
                        {
                            isRunning = false;
                            keyMaterials[item] -= 250;

                            switch (item)
                            {
                                case "shards":
                                    Console.WriteLine($"Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine($"Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine($"Dragonwrath obtained!");
                                    break;
                            }

                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(item))
                        {
                            junkMaterials[item] += quantity;
                        }
                        else
                        {
                            junkMaterials.Add(item, quantity);
                        }
                    }
                }
            }

            Dictionary<string, int> sortedItems = keyMaterials
                .OrderByDescending(n => n.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(i => i.Key, i => i.Value);

            foreach (var item in sortedItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
