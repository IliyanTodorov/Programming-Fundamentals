using System;

namespace _04.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ReadPoint();
            var input2 = ReadPoint();

            var result = CalcDistance(input, input2);
            Console.WriteLine($"{result:F3}");
        }

        static Points ReadPoint()
        {
            var input = Console.ReadLine().Split();

            var point = new Points
            {
                X = int.Parse(input[0]),
                Y = int.Parse(input[1])
            };

            return point;
        }

        public static double CalcDistance(Points p1, Points p2)
        {
            var xDiff = p1.X - p2.X;
            var xPow = xDiff * xDiff;

            var yDiff = p1.Y - p2.Y;
            var yPow = yDiff * yDiff;

            return Math.Sqrt(xPow + yPow);
        }
    }
}
