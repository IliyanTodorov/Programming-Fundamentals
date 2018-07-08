namespace _11._Equal_Sums
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

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] firstArr = numbers.Take(i).ToArray();
                int[] secondArr = numbers.Skip(i + 1).ToArray();

                if (firstArr.Sum() == secondArr.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
