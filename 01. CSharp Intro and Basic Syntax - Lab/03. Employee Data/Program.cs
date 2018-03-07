using System;

namespace _03._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var EmployeeId = int.Parse(Console.ReadLine());
            decimal salry = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {EmployeeId:D8}");
            Console.WriteLine($"Salary: {salry:F2}");
        }
    }
}
