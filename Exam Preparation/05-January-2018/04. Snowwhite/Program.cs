using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace _04._Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var colorsToDwarfs = new Dictionary<string, List<Dwarf>>();
            var allDwarfs = new List<Dwarf>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Once upon a time")
                {
                    break;
                }

                string[] dwarfInfo = line
                    .Split(new char[] {' ', '<', ':', '>'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                if (!colorsToDwarfs.ContainsKey(color))
                {
                    colorsToDwarfs[color] = new List<Dwarf>();
                }

                var dwarfsByCurrentColor = colorsToDwarfs[color];

                var foundDwarf = dwarfsByCurrentColor
                    .FirstOrDefault(d => d.Name == name);

                if (foundDwarf != null)
                {
                    foundDwarf.Physics = Math.Max(physics, foundDwarf.Physics); 
                }
                else
                {
                    var dwarf = new Dwarf
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };

                    dwarfsByCurrentColor.Add(dwarf);
                    allDwarfs.Add(dwarf);
                }
            }

            var results = allDwarfs
                .OrderByDescending(d => d.Physics)
                .ThenByDescending(d => colorsToDwarfs[d.Color].Count())
                .ToList();

            foreach (var dwarf in results)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
