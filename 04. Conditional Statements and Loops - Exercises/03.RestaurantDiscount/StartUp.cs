namespace _03.RestaurantDiscount
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0;
            double discount = 0;

            if (groupSize <= 50)
            {
                price = 2500;
                Console.WriteLine($"We can offer you the Small Hall");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                price = 5000;
                Console.WriteLine($"We can offer you the Terrace");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                price = 7500;
                Console.WriteLine($"We can offer you the Great Hall");
            }
            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
                return;
            }
            int packagesPrice = 0;

            if (package == "Normal")
            {
                packagesPrice = 500;
                discount = (price + 500) * 0.05;
            }
            else if (package == "Gold")
            {
                packagesPrice = 750;
                discount = (price + 750) * 0.1;
            }
            else if (package == "Platinum")
            {
                packagesPrice = 1000;
                discount = (price + 1000) * 0.15;
            }

            double AllPrice = ((price + packagesPrice) - discount) / groupSize;

            Console.WriteLine($"The price per person is {AllPrice:F2}$");
        }
    }
}
