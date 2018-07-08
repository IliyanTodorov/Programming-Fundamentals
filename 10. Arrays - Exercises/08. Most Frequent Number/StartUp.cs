namespace _08._Most_Frequent_Number
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

            int result = 0;
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int currentOccurances = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        currentOccurances++;

                        if (currentOccurances > total)
                        {
                            total = currentOccurances;
                            result = currentNumber;
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
