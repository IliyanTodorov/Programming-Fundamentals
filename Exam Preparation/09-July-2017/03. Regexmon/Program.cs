using System;
using System.Text.RegularExpressions;

namespace _03._Regexmon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string DidimonPattern = @"[^A-Za-z-]+";
            string BojomonPattern = @"[A-Za-z]+\-[A-Za-z]+";

            var didiRegex = new Regex(DidimonPattern);
            var bojoRegex = new Regex(BojomonPattern);

            while (true)
            {
                var didiMatch = didiRegex.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value);
                }
                else return;

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                var bojoMatch = bojoRegex.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value);
                }
                else return;

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
            }
        }
    }
}
