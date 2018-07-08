using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var Sale = ReadSale();
                var currentPrice = Sale.Price * Sale.Quantity;

                if (!dict.ContainsKey(Sale.Town))
                {
                    dict.Add(Sale.Town, new decimal());
                }
                dict[Sale.Town] += currentPrice;
            }

            foreach (var item in dict.OrderBy(town => town.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
        static Sales ReadSale()
        {
            var line = Console.ReadLine().Split();

            return new Sales()
            {
                Town = line[0],
                Product = line[1],
                Price = decimal.Parse(line[2]),
                Quantity = decimal.Parse(line[3])
            };

        }
    }
}
