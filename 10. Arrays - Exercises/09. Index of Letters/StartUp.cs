namespace _09._Index_of_Letters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];

            int counter = 0;
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabet[counter] = letter;
                counter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (currentLetter == alphabet[j])
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    }
                }
            }
        }
    }
}
