using System;


namespace WhileLoopsProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You have 5 dollars. You need 10 dollars to go see a movie.");

            int money = 5;
            int moneyNeeded;
            bool hasMoney = money >= 10;
            while (!hasMoney)
            {
                moneyNeeded = 10 - money;
                Console.WriteLine("You need "+moneyNeeded+" more dollars to see the movie.");
                Console.WriteLine("Type \"d\" to gain a dollar");
                string input = Console.ReadLine().ToLower();
                if(input == "d")
                {
                    money += 1;
                    hasMoney = money >= 10;
                }
                else
                {
                    Console.WriteLine("Oops, you didn't type \"d\".  Try again");
                }
            }
            Console.WriteLine("You have enough money now! Enjoy the show.");
            Console.Read();
        }
    }
}
