using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Pokemon_Evolution
{
    class Evolutions
    {
        public string Type { get; set; }

        public int Index { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // {pokemonName} -> {evolutionType} -> {evolutionIndex}
            var pokemon = new Dictionary<string, List<Evolutions>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "wubbalubbadubdub")
                {
                    break;
                }

                var tokens = line.Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = tokens[0];

                if (tokens.Count == 1)
                {
                    if (pokemon.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var evolution in pokemon[name])
                        {
                            Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                        }
                    }
                }
                else if (tokens.Count > 1)
                {
                    var type = tokens[1];
                    int index = int.Parse(tokens[2]);

                    var newEvolution = new Evolutions();
                    newEvolution.Type = type;
                    newEvolution.Index = index;

                    if (!pokemon.ContainsKey(name))
                    {
                        pokemon[name] = new List<Evolutions>();    
                    }
                    
                    pokemon[name].Add(newEvolution);
                }
            }

            foreach (var name in pokemon)
            {
                Console.WriteLine($"# {name.Key}");
                foreach (var any in name.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{any.Type} <-> {any.Index}");
                }
            }
        }
    }
}



// https://pastebin.com/byhhU33m
// https://judge.softuni.bg/Contests/Practice/Index/692#1
// http://www.nakov.com/books/
// http://www.introprogramming.info/intro-csharp-book/