namespace _03._Fold_and_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] leftArr = numbers.Take(k).ToArray();
            int[] middleArr = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightArr = numbers.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = new int[2 * k];
            
            for (int index = 0; index < k; index++)
            {
                result[index] = leftArr[index] + middleArr[index];
                result[index + k] = rightArr[index] + middleArr[index + k];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
