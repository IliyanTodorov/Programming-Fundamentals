using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial pTutorial = new Tutorial();

            pTutorial.SetTutorial(1, ".Net");

            Console.WriteLine(pTutorial.GetTutorial());

        }
    }
}
