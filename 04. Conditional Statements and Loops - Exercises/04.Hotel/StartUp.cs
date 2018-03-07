namespace _04.Hotel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioP = 0;
            double doubleP = 0;
            double suiteP = 0;
            double discount = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7)
                {
                    discount = 0.05;
                    studioP = 50 - (50 * 0.05);   
                }
                else
                {
                    studioP = 50;
                }
                doubleP = 65;
                suiteP = 75;
               
            }
            else if (month == "June" || month == "September")
            {
                studioP = 60;
                if (nights > 14)
                {
                    discount = 0.1;
                    doubleP = 72 - (72 * 0.1);
                }
                else
                {
                    doubleP = 72;
                }
                suiteP = 82;
                
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioP = 60;
                doubleP = 72;
                if (nights > 14)
                {
                    discount = 0.15;
                    suiteP = 82 - (82 * 0.15);
                }
                else
                {
                    suiteP = 82;
                }
            }
            if (month == "September" || month == "October")
            {
                if (nights > 14)
                {
                    nights = nights - 1;
                }
            }

            
            Console.WriteLine($"Studio: {nights * studioP:F2} lv.");
            Console.WriteLine($"Double: {nights * doubleP:F2} lv.");
            Console.WriteLine($"Suite: {nights * suiteP:F2} lv.");
        }
    }
}