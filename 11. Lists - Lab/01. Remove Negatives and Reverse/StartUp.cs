namespace _01._Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] < 0)
                {
                    listOfIntegers.Remove(listOfIntegers[i]);
                    i--;
                }
            }

            int lenght = listOfIntegers.Count;
            int[] reversed = new int[lenght];

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                reversed[lenght - i - 1] = listOfIntegers[i];
            }

            if (listOfIntegers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }
    }
}
