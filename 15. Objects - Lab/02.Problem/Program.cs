using System;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];

                var randomIndex = random.Next(0, input.Length);
                var randomWord = input[randomIndex];

                input[i] = randomWord;
                input[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
