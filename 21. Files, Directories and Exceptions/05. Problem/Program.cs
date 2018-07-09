using System;
using System.IO;
using System.Linq;

namespace _05._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalSize = Directory
                .GetFiles("Names")
                .Select(f => new FileInfo(f))
                .Sum(f => f.Length);

            Console.WriteLine(totalSize / 1024.0 / 1024);
        }
    }
}
