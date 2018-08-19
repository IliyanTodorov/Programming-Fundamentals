using System;

namespace _01._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int counter = 0;

            double money = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        counter++;
                        if (counter % 2 == 0)
                        {
                            // display
                            money += display;
                        }

                        // keyboard + counter
                        money += keyboard;
                        
                    }

                    // headset
                    money += headset;
                }

                if (i % 3 == 0)
                {
                    // mouse
                    money += mouse;
                }
            }

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
