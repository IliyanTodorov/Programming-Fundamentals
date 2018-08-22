using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var snowmans = Console.ReadLine()
                .Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (snowmans.Count > 1)
            {
                for (int i = 0; i < snowmans.Count; i++)
                {
                    if (snowmans.Count(c => c != -1) == 1)
                    {
                        break;
                    }

                    if (snowmans[i] == -1)
                    {
                        continue;
                    }

                    int attacker = i;
                    int target = snowmans[i] % snowmans.Count;

                    var diff = Math.Abs(attacker - target);

                    if (attacker == target)
                    {
                        snowmans[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");

                    }
                    else if (diff % 2 == 0)
                    {
                        snowmans[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }
                    else
                    {
                        snowmans[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                }

                snowmans = snowmans.Where(x => x != -1).ToList();

            }
        }
    }
}
