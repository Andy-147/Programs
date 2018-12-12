using System;
using System.Collections.Generic;

namespace List_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup used to set up the rest of the program
            List<string> games = new List<string>();
            List<string> rank = new List<string>();
            games.Add("Kingdom Hearts");
            rank.Add("1");

            string stopWord = "End";
            string userGame = "";
            string userEnteredRank = "";
            string userAnswer1;

            //Start Menu - gives options to user
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Start");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(" Make a selection on where you would like to go:");
            Console.WriteLine("  1. Add a game to the list");
            Console.WriteLine("  2. View the game and ranking");
            Console.WriteLine("  3. Exit program");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");

            userAnswer1 = Console.ReadLine(); 

            switch (userAnswer1)
            {
                case ("1"):
                    goto AddGame;
                case ("2"):
                    goto ViewGame;
                case ("3"):
                    goto Exit;

            }

        AddGame:
            // Adds a game into the list
            while (userGame != stopWord)
            {
                Console.WriteLine("Please enter a game name");
                userGame = Console.ReadLine();

                Console.WriteLine("Please enter a rank");
                userEnteredRank = Console.ReadLine();

                if (userGame == "Kingdom Hearts" || userEnteredRank == "1")
                {
                    Console.WriteLine("Please enter another game name or rank - that is already in use.");
                    userEnteredRank = "";
                    userGame = "";
                }
                else
                {
                    games.Add(userGame);
                    rank.Add(userEnteredRank);
                }
            }
        




        ViewGame:

            Console.WriteLine("What game do you want to see?");
            string gameToSee = "";

            gameToSee = Console.ReadLine();

            Console.WriteLine("Game you wanted to see: ");
            Console.WriteLine("Game: " + games.Contains(gameToSee));
            int indexOfRankofGame = games.IndexOf(gameToSee);
            if (indexOfRankofGame == -1)
            {
                Console.WriteLine("You did not find a game with the name " + gameToSee);
            }
            Console.WriteLine("The rank of the game " + gameToSee + " is " + rank[indexOfRankofGame]);
            Console.ReadLine();

        Exit:
            Console.WriteLine("");
            Console.WriteLine("Thank you");
            Console.ReadLine();

        }
    }
}
