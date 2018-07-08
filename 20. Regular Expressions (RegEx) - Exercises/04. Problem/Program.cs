using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<city>[A-Z]{2})(?<temperature>[\d]+\.[\d]{1,2})(?<weather>[A-Za-z]+)\|";
            Dictionary<string, KeyValuePair<double, string>> data = new Dictionary<string, KeyValuePair<double, string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var city = match.Groups["city"].Value;
                    double temperature = double.Parse(match.Groups["temperature"].Value);
                    var weather = match.Groups["weather"].Value;
                    if (!data.ContainsKey(city))
                    {
                        data[city] = new KeyValuePair<double, string>(temperature, weather);
                    }
                    else
                    {
                        data[city] = new KeyValuePair<double, string>(temperature, weather);
                    }
                }
            }
            var sortedDict = data.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var d in sortedDict)
            {
                Console.WriteLine($"{d.Key} => {d.Value.Key:F2} => {d.Value.Value}");
            }
        }
    }
}
