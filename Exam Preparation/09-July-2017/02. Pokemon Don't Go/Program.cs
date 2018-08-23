using System;
using System.Linq;

namespace _02._Pokemon_Don_t_Go // 90/100
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (pokemons.Count != 0)
            { 
                int index = int.Parse(Console.ReadLine());

                int firstEl = pokemons.First();
                int lastEl = pokemons.Last();

                if (pokemons.Count <= index)
                {
                    sum += lastEl;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(firstEl);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > lastEl)
                        {
                            pokemons[i] -= lastEl;
                        }
                        else if (pokemons[i] <= lastEl)
                        {
                            pokemons[i] += lastEl;
                        }
                    }
                    continue;
                }

                if (index < 0)
                {
                    sum += firstEl;
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, lastEl);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > firstEl)
                        {
                            pokemons[i] -= firstEl;
                        }
                        else if (pokemons[i] <= firstEl)
                        {
                            pokemons[i] += firstEl;
                        }
                    }
                    continue;
                }

                int currentNum = pokemons[index];

                sum += currentNum;
                pokemons.Remove(currentNum);

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] > currentNum)
                    {
                        pokemons[i] -= currentNum;
                    }
                    else if (pokemons[i] <= currentNum)
                    {
                        pokemons[i] += currentNum;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
