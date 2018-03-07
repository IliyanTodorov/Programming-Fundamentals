namespace _02.ChooseADrink2._0
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                Console.WriteLine($"The Athlete has to pay {0.70 * quantity:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The SoftUni Student has to pay {1.70 * quantity:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {quantity:F2}.");
            } 
            else
            {
                Console.WriteLine($"The {profession} has to pay {1.20 * quantity:F2}.");
            }
        }
    }
}
