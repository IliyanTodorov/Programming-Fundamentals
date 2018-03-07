using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredients = 0 ;

            while (ingredient != "Bake!")
            {
                ingredients += 1;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                if (ingredients > 20)
                {
                    return;
                }
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
