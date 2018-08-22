using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var websites = new List<string>();

            int n = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());

            decimal loss = 0M;

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                string website = input[0];
                long visits = long.Parse(input[1]);
                decimal pricePerVisit = decimal.Parse(input[2]);

                loss += visits * pricePerVisit;

                websites.Add(website);
            }

            foreach (var website in websites)
            {
                Console.WriteLine(website);
            }
            Console.WriteLine($"Total Loss: {loss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(secKey, websites.Count)}");
        }
    }
}
