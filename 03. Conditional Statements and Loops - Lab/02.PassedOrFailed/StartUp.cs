namespace _02.PassedOrFailed
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double evaluation = double.Parse(Console.ReadLine());
            
            if (evaluation >= 3)
            {
                Console.WriteLine($"Passed!");
            }
            else
            {
                Console.WriteLine($"Failed!");
            }

        }
    }
}
