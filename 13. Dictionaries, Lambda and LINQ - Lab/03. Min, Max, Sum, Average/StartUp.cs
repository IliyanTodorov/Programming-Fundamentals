﻿namespace _03._Min__Max__Sum__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine($"Sum = {numbers.Sum()}");
                Console.WriteLine($"Min = {numbers.Min()}");
                Console.WriteLine($"Max = {numbers.Max()}");
                Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
