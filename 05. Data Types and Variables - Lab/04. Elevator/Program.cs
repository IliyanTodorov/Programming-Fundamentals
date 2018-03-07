using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPerson = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int needCourses = 0;

            needCourses = (int)Math.Ceiling(numberOfPerson / (double)elevatorCapacity);
            Console.WriteLine($"{needCourses}");
        }
    }
}
