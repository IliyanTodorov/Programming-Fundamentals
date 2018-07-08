namespace _06._Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int startIndex = 0;
            int currentLenght = 1;
            int maxStart = 0;
            int maxLenght = 1;

            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] == numbers[index - 1])
                {
                    currentLenght++;

                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        maxStart = startIndex;
                    }
                }
                else
                {
                    currentLenght = 1;
                    startIndex = index;
                }
            }

            for (int index = maxStart; index < maxStart + maxLenght; index++)
            {
                Console.Write(numbers[index] + " ");
            }
        }
    }
}
