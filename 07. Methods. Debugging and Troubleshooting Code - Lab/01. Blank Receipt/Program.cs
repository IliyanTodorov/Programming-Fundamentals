using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        public static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintHeader()
        {
            Console.WriteLine($"CASH RECEIPT");
            Console.WriteLine($"------------------------------");
        }
        public static void PrintBody()
        {
            Console.WriteLine($"Charged to____________________");
            Console.WriteLine($"Received by___________________");
        }
        public static void PrintFooter()
        {
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"\u00A9 SoftUni");
        }
    }
}
