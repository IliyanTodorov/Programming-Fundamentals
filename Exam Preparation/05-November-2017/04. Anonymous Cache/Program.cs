using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args) // 100/100
        {
            // dataSet -> dataKey -> dataSize
            var dataSet = new Dictionary<string, Dictionary<string, long>>();
            // dataSet -> dataKey -> dataSize
            var cache = new Dictionary<string, Dictionary<string, long>>(); 
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "thetinggoesskrra")
                {
                    break;
                }

                if (input.Contains(" -> ") && input.Contains(" | "))
                {
                    var tokens = input
                        .Split(new char[] {' ', '-', '>', '|'}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string Key = tokens[0];
                    long Size = long.Parse(tokens[1]);
                    string Set = tokens[2];

                    if (!dataSet.ContainsKey(Set))
                    {
                        if (!cache.ContainsKey(Set))
                        {
                            cache.Add(Set, new Dictionary<string, long>());
                            
                        }
                        cache[Set].Add(Key, Size);

                    }
                    else
                    {
                        dataSet[Set].Add(Key, Size);
                    }
                }
                else if (input.Split().Length == 1)
                {
                    string Set = input;

                    if (!dataSet.ContainsKey(Set))
                    {
                        dataSet.Add(Set, new Dictionary<string, long>());
                    }

                    if (cache.ContainsKey(Set))
                    {
                        foreach (var kvp in cache[Set])
                        {
                            dataSet[Set].Add(kvp.Key, kvp.Value);
                        }
                    }
                }
            }

            var highestSum = dataSet.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var token in dataSet.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {token.Key}, Total Size: {token.Value.Values.Sum()}");
                foreach (var valueKey in token.Value.Keys)
                {
                    Console.WriteLine($"$.{valueKey}");
                }
                return;
            }
        }
    }
}
