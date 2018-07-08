using System;
using System.Numerics;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            { 
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
