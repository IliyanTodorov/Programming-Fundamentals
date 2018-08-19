using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> submitions = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                string[] splitedInput = input.Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = splitedInput[0];

                if (!splitedInput.Contains("banned"))
                {
                    string language = splitedInput[1];
                    int points = int.Parse(splitedInput[2]);

                    if (!submitions.ContainsKey(language))
                    {
                        submitions.Add(language, 1);
                    }
                    else
                    {
                        submitions[language]++;
                    }

                    if (!results.ContainsKey(name))
                    {
                        results[name] = new Dictionary<string, int>();
                        results[name].Add(language, points);
                    }
                    else if (!results[name].ContainsKey(language))
                    {
                        results[name].Add(language, points);
                    }
                    else
                    {
                        if (results[name][language] < points)
                        {
                            results[name][language] = points;
                        }
                    }
                }
                else
                {
                    if (results.ContainsKey(name))
                    {
                        results.Remove(name);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Results:");
            foreach (var item in results.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value.Values.Sum()}");
            }

            Console.WriteLine($"Submissions:");
            foreach (var sub in submitions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{sub.Key} - {sub.Value}");
            }
        }
    }
}
