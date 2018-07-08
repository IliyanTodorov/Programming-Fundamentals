namespace _01._Largest_Common_End
{
    using System;
    using System.Linq;

    public class startUp
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            int equalElements = 0;

            for (int index = 0; index < lenght; index++)
            {
                if (firstArray[index] == secondArray[index])
                {
                    equalElements++;
                }
            }

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int reversedCounter = 0;

            for (int index = 0; index < lenght; index++)
            {
                if (firstArray[index] == secondArray[index])
                {
                    reversedCounter++;
                }
            }

            if (equalElements >= reversedCounter)
            {
                Console.WriteLine(equalElements);
            }
            else
            {
                Console.WriteLine(reversedCounter);
            }

            
        }
    }
}
