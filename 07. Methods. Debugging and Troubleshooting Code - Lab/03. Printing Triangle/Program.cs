using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                PrintTriangle(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }

        public static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i}");
                Console.Write(" ");
            }
            Console.WriteLine();

        }
    }
}
