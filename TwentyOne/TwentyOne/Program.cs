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
            Deck deck = new Deck();
            //deck = Deck.Shuffle(deck);           
            //deck = Deck.Shuffle(deck: deck, times: 5);            
            // out params must be declared ex.(out <data type> timesShuffled) on function call
            deck = Deck.Shuffle(deck, out int timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count());
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();

            
        }
        

    }
}
