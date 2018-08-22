using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x >= 0 && x < fieldSize)
                .ToList()
                .ForEach(i => field[i] = 1);

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                int landIndex = ladybugIndex;

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                if (OutOfField(fieldSize, ladybugIndex) || field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                while (true)
                {
                    landIndex += flyLength;

                    if (OutOfField(fieldSize, landIndex))
                    {
                        break;
                    }

                    if (field[landIndex] == 0)
                    {
                        field[landIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }

        public static bool OutOfField(int fieldSize, int index)
        {
            return index < 0 || index >= fieldSize;
        }
    }
}
