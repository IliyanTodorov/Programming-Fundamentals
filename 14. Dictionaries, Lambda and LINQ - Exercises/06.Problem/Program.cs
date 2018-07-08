using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> information = new SortedDictionary<string, Dictionary<string, int>>();

            

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                    break;

                string[] tokens = line.Split(" ").ToArray();

                string[] IPAdress = tokens[0].Split("=").ToArray();
                string[] Message = tokens[1].Split("\'").ToArray();
                string[] UserName = tokens[2].Split("=").ToArray();

                string IP = IPAdress[1];
                string message = Message[1];
                string user = UserName[1];

                int counterOfMessages = 1;

                if (!information.ContainsKey(user))
                {
                    information.Add(user, new Dictionary<string, int>());
                }
                if (!information[user].ContainsKey(IP))
                {
                    information[user].Add(IP, counterOfMessages);
                }
                else
                {
                    information[user][IP]++;
                }
            }

            foreach (var item in information)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var log in item.Value)
                {
                    if (log.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
