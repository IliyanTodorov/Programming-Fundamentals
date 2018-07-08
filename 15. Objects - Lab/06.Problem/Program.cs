using System;

namespace _06.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = ReadRectangle();
            var second = ReadRectangle();

            var result = first.isInside(second);
            Console.WriteLine(result ? "Inside" : "Not Inside");
        }

        static Rectangle ReadRectangle()
        {
            var datas = Console.ReadLine().Split();

            return new Rectangle
            {
                Left = int.Parse(datas[0]),
                Top = int.Parse(datas[1]),
                Width = int.Parse(datas[2]),
                Height = int.Parse(datas[3])
            };
        }
    }

    
}
