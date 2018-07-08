namespace _01._Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currentStart = 0;
            int currentLenght = 1;
            int bestStart = 0;
            int bestLenght = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                int firstNum = numbers[i];
                int secondNum = numbers[i - 1];

                if (firstNum == secondNum)
                {
                    currentLenght++;

                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestStart = currentStart;
                    }

                }
                else
                {
                    currentLenght = 1;
                    currentStart = i;
                }
            }

            for (int k = bestStart; k < bestStart + bestLenght; k++)
            {
                Console.Write(numbers[k] + " ");
            }
        }
    }
}
