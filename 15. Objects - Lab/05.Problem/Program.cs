using System;
using System.Collections.Generic;

namespace _05.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Points>();

            for (int i = 0; i < n; i++)
            {
                var current = ReadPoint();

                list.Add(current);
            }

            var minDistance = double.MaxValue;
            Points firstMinPoint = null;
            Points secondMinPoint = null;

            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    var firstPoint = list[i];
                    var secondPoint = list[k];

                    var currentDistance = CalcDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstMinPoint.X}, {firstMinPoint.Y})");
            Console.WriteLine($"({secondMinPoint.X}, {secondMinPoint.Y})");
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