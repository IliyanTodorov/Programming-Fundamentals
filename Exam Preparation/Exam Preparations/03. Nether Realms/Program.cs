using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var demonHealths = new SortedDictionary<string, double>();
            var demondamages = new SortedDictionary<string, double>();

            var pattern = @"-?\d+\.?\d*";
            var regex = new Regex(pattern);

            foreach (var demon in demons)
            {
                var health = demon
                    .Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.')
                    .Sum(s => s);

                demonHealths[demon] = health;

                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var value = match.Value;
                    damage += double.Parse(value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                demondamages[demon] = damage;
            }

            foreach (var demon in demondamages)
            {
                var demonName = demon.Key;
                var demonDamage = demon.Value;
                var demonHealth = demonHealths[demonName];

                Console.WriteLine($"{demonName} - {demonHealth} health, {demonDamage:f2} damage");
            }
        }
    }
}
