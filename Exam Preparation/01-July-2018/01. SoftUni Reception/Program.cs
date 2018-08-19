using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int empoyee1 = int.Parse(Console.ReadLine());
            int empoyee2 = int.Parse(Console.ReadLine());
            int empoyee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int studentPerHour = empoyee1 + empoyee2 + empoyee3;

            int hours = 0;

            while (studentsCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                else
                {
                    studentsCount -= studentPerHour;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
