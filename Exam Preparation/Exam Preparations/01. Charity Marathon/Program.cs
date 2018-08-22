using System;

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int avarageLaps = int.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKM = double.Parse(Console.ReadLine());

            double money = 0;

            int totalCapacity = capacity * marathonDays;

            if (runners > totalCapacity)
            {
                runners = totalCapacity;
            }

            long totalMeters = runners * avarageLaps * trackLength;
            long totalKM = totalMeters / 1000;
            money = totalKM * moneyPerKM;

            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
