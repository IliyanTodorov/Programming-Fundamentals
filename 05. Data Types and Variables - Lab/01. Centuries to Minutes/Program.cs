using System;

namespace _01._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort centuaries = ushort.Parse(Console.ReadLine());
            int years = centuaries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = 60 * hours;
            Console.WriteLine($"{centuaries} Centuaries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
