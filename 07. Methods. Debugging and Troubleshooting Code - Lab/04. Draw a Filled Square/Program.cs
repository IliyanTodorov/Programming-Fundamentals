using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            PrintHeaderRow(size);
            PrintMiddleRow(size);
            PrintHeaderRow(size);
        }

        private static void PrintMiddleRow(int size)
        {
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write("-");

                for (int j = 1; j < size; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
            }
        }

        private static void PrintHeaderRow(int size)
        {
            Console.WriteLine(new string('-', size * 2));
        }
    }
}
