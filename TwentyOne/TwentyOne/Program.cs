using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Some text.";            
            //File.WriteAllText(@"C:\Users\danie\Logs\log.txt", text);
            //string text = File.ReadAllText(@"C:\Users\danie\Logs\log.txt");

            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "yup" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }


    }
}
