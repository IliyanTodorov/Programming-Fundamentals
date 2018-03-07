namespace _01.Passed
{
    using System;

    public class StratUp
    {
        public static void Main()
        {
            double evaluation = double.Parse(Console.ReadLine());

            if (evaluation >= 3)
            {
                Console.WriteLine($"Passed!");
            }
        }
    }
}
