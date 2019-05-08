using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {


            //Polymorphism
            //Game game = new TwentyOneGame();
            //List<Game> games = new List<Game>();
            //games.Add(game);

            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            List<int> numberList = new List<int>() { 3, 45, 12, 8, 0, 4 };
            int sum = numberList.Sum(x => x + 5);
            Console.WriteLine(sum);

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            Console.ReadLine();



            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count());            
            Console.ReadLine();


        }


    }
}
