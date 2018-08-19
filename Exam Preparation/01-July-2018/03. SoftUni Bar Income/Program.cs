using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> output = new List<string>();

            string pattern =
                @"^%(?<customer>[A-Z][a-z]+)%[^|%.$]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]+\.?[0-9]+)\$";

            string input = Console.ReadLine();
            double totalIncome = 0;

            while (input != "end of shift")
            {
                var reg = Regex.Match(input, pattern);

                if (reg.Success)
                {
                    var customer = reg.Groups["customer"].Value;
                    var product = reg.Groups["product"].Value;
                    var count = int.Parse(reg.Groups["count"].Value);
                    var price = double.Parse(reg.Groups["price"].Value);

                    double totalPrice = count * price;

                    totalIncome += totalPrice;

                    output.Add($"{customer}: {product} - {totalPrice:F2}");
                }
                input = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
