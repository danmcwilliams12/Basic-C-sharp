using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jessie", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();
            //Polymorphism
            //Game game = new TwentyOneGame();
            //List<Game> games = new List<Game>();
            //games.Add(game);

            Deck deck = new Deck();
            //deck = Deck.Shuffle(deck);           
            //deck = Deck.Shuffle(deck: deck, times: 5);            
            // out params must be declared ex.(out <data type> timesShuffled) on function call
            
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count());            
            Console.ReadLine();

            
        }
        

    }
}
