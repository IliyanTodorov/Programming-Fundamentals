namespace _10.MultiplicationTable2._0
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            for (int i = secNum; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
            if (secNum > 10)
            {
                Console.WriteLine($"{num} X {secNum} = {num * secNum}");
            }
        }
    }
}
