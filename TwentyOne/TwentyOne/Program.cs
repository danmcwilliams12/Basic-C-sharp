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
            game.Dealer = "Jessie";
            game.Players = new List<string>() { "Jessie", "Bill", "Joe" };
            game.ListPlayers();            
            game.Play();
            Console.ReadLine();

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
