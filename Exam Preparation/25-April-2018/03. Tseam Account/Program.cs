using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            while (input != "Play!")
            {
                string[] splitedInput = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = splitedInput[0];
                string game = splitedInput[1];

                switch (command)
                {
                    case "Install":
                        if (!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;

                    case "Uninstall":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;
                    case "Update":
                        if (games.Contains(game))
                        {
                            int gamePosition = games.IndexOf(game);

                            games.RemoveAt(gamePosition);
                            games.Add(game);
                        }
                        break;
                    case "Expansion":
                        string[] splitedGame = game.Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                        string orgGame = splitedGame[0];
                        string expansion = splitedGame[1];

                        if (games.Contains(orgGame))
                        {
                            int index = games.IndexOf(orgGame);
                            games.Insert((index + 1), orgGame + ":" + expansion);
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", games));
        }
    }
}
