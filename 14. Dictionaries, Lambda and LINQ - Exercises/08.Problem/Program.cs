using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] tokens = line.Split(" ").ToArray();

                string IP = tokens[0];
                string user = tokens[1];
                int duration = Int32.Parse(tokens[2]);

                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new SortedDictionary<string, int>());
                }
                if (!logs[user].ContainsKey(IP))
                {
                    logs[user].Add(IP, duration);
                }
                else
                {
                    logs[user][IP] += duration;
                }
            }

            foreach (var user in logs)
            {
                var totalDurationOfUser = logs[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
