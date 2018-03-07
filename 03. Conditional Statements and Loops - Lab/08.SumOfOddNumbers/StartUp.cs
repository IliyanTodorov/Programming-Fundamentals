namespace _08.SumOfOddNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int sec = 1;

            for (int i = 1; i <= num ; i++)
            {
                Console.WriteLine(sec);
                sum += sec;
                sec += 2;
            }
            Console.WriteLine(sum);
        }
    }
}
