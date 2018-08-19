using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args) // 80/100 I dkn why
        {
            var playerPool = new Dictionary<string, Dictionary<string, double>>();
            Dictionary<string, int> skills = new Dictionary<string, int>();


            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (!input.Contains(" vs "))
                {
                    var splitedInput = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string player = splitedInput[0];
                    string position = splitedInput[1];
                    double points = double.Parse(splitedInput[2]);

                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool.Add(player, new Dictionary<string, double>());
                        playerPool[player].Add(position, points);
                    }
                    else if (!playerPool[player].ContainsKey(position))
                    {
                            playerPool[player].Add(position, points);
                    }
                    else if (playerPool[player].ContainsKey(position))
                    {
                        if (playerPool[player][position] < points)
                        {
                            playerPool[player][position] = points;
                        }
                    }
                }
                else if (input.Contains(" vs "))
                {
                    var splitedInput = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player1 = splitedInput[0];
                    string player2 = splitedInput[1];

                    if (playerPool.ContainsKey(player1) && playerPool.ContainsKey(player2))
                    {
                        int mostPostions = Math.Max(playerPool[player1].Keys.Count, playerPool[player2].Keys.Count);
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (var posKey1 in playerPool[player1].Keys)
                            {
                                foreach (var posKey2 in playerPool[player2].Keys)
                                {
                                    if (posKey1 == posKey2)
                                    {
                                        double faker = playerPool[player1][posKey1];
                                        double bush = playerPool[player2][posKey2];

                                        if (playerPool[player1][posKey1] < playerPool[player2][posKey2])
                                        {
                                            playerPool.Remove(player1);
                                            break;
                                        }
                                        else if (playerPool[player1][posKey1] > playerPool[player2][posKey2])
                                        {
                                            playerPool.Remove(player2);
                                            break;
                                        }
                                    }       
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");
                foreach (var stats in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {stats.Key} <::> {stats.Value}");
                }
            }
        }
    }
}
