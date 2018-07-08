namespace _04._Sieve_of_Eratosthenes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n + 1];
            prime[0] = false;
            prime[1] = false;

            for (int index = 2; index < prime.Length; index++)
            {
                prime[index] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (prime[i])
                {
                    for (int p = i * i; p <= n; p+= i)
                    {
                        prime[p] = false;
                    }
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < prime.Length; i++)
            {
                if (prime[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}