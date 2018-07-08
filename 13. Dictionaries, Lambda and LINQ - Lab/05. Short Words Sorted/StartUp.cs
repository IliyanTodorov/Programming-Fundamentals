namespace _05._Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrayOfWords = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> smallNums = new List<string>();

            foreach (var item in arrayOfWords)
            {
                if (item.Length < 5)
                {
                    smallNums.Add(item);
                }       
            }

            var result = smallNums
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
