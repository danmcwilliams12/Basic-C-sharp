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
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Suit = Suit.Hearts;

            Console.WriteLine(card2.Face);

            //operator overload example
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Dan";
            //game += player;
            //game -= player;


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
