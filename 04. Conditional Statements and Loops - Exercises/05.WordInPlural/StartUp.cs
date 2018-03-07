namespace _05.WordInPlural
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input.EndsWith("y"))
            {
                input = input.Substring(0, input.Length - 1);
                input += "ies";
            }
            else if (input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") ||
                  input.EndsWith("sh") || input.EndsWith("x") || input.EndsWith("z"))
            {
                input += "es";
            }
            else
            {
                input += 's';
            }
            Console.WriteLine($"{input}");
        }
    }
}