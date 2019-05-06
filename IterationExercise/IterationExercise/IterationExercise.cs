using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercise
{
    class Program
    {
        static void Main()
        {
            string[] cars = new string[] { "Fiesta", "Fiat 500", "Mustang", "Corvette", "Civic" };
            Console.WriteLine("Please type a word");
            string word = Console.ReadLine();
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] += word;
            }
            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
            }
            Console.ReadLine();


            int[] infinityArray = new int[] { 1, 0, -2};
            Console.WriteLine("To infinity, and Beyond");
            for (int i = 0; i < infinityArray.Length; i++)
            {
                Console.WriteLine("This is the loop that never ends...");
                // removed these lines to break infinite loop
                //int infinityEngine = infinityArray[i];
                //i += infinityEngine;
            }
            Console.ReadLine();

            string[] cars2 = new string[] { "Fiesta", "Fiat 500", "Mustang", "Corvette", "Civic" };

            for (int i = 0; i < cars2.Length; i++)
            {
                if (cars2[i].Length > 6)
                {
                    Console.WriteLine(cars2[i]);
                }
            }
            Console.ReadLine();
            Random rnd = new Random();
            for (int i = 0; i <= cars2.Length; i++)
            {           
                Console.WriteLine(cars2[rnd.Next(0, 5)]);
            }
            Console.ReadLine();

            List<string> beatles = new List<string> { "john", "paul", "george", "ringo" };
            Console.WriteLine("Please type the name of your favorite Beatle.");
            string favBeatle = Console.ReadLine().ToLower();

            while (!beatles.Contains(favBeatle))
            {
                Console.WriteLine("That Beatle does not exsist, try again!");
                favBeatle = Console.ReadLine().ToLower();
            }

            foreach (string beatle in beatles)
            {                            
                if (beatle.ToLower() == favBeatle)
                    {
                        Console.WriteLine("Your favorite Beatle is at index: " + beatles.IndexOf(beatle));
                    break;
                    }                                                      
            }
            Console.ReadLine();
            List<string> pets = new List<string> { "dog", "cat", "hampster", "snake", "fish", "dog", "cat", "fish", "dog", "hampster" };       
            Console.WriteLine("Enter a common pet.");
            string inputPet = Console.ReadLine().ToLower();

            while (!pets.Contains(inputPet))
            {
                Console.WriteLine("That pet is not in the list, try again!");
                inputPet = Console.ReadLine().ToLower();
            }
            int x = 0;
            foreach (string pet in pets)
            {
                if(pet == inputPet)
                {
                    Console.WriteLine("Your pet is at index: " + pets.IndexOf(pet, x));
                }
                x++;
            }
            Console.ReadLine();

            List<string> letters = new List<string> { "a", "k", "g", "r", "a", "d", "h", "z", "r", "i", "p", "k", "a", "x", "n", "j", "f", "d", "b", };
            int y = 0;
            foreach (string letter in letters)
            {
                if (letters.GetRange(0, y).Contains(letter))
                {
                    Console.WriteLine(letter + " this letter has appeared before in the list.");
                }
                else
                {
                    Console.WriteLine(letter);
                }
                y++;
            }
            Console.ReadLine();
        }
    }
}
