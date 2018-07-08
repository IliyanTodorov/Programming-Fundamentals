namespace _10._Pairs_by_Difference

{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int defference = int.Parse(Console.ReadLine());

            int pairs = 0;
           

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] - numbers[j] == defference || numbers[j] - numbers[i] == defference)
                    {
                        pairs++;
                    }
                }
            }
            Console.WriteLine($"{pairs}");
        }
    }
}
