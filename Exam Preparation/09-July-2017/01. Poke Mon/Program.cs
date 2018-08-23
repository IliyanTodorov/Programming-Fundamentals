using System;

namespace _01._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());

            long count = 0;

            decimal fifthProcent = n * 0.5m;

            while (m <= n)
            {
                count++;
                n -= m;

                if (fifthProcent == n)
                {
                    if (y > 0)
                    {
                        n /= y;
                    }
                }

            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
