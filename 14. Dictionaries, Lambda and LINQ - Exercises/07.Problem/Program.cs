using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> population = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> countyPopulation = new Dictionary<string, long>();
            

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "report")
                    break;

                string[] delivered = line.Split("|").ToArray();

                string city = delivered[0];
                string country = delivered[1];
                long people = long.Parse(delivered[2]);

                if (population.ContainsKey(country) == false)
                {
                    population.Add(country, new Dictionary<string, long>());
                    countyPopulation.Add(country, 0);
                }

                population[country].Add(city, people);
                countyPopulation[country] += people;

            }

            foreach (var country in countyPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                Dictionary<string, long> cities = population[country.Key]
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
