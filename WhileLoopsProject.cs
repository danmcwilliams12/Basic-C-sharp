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
            Console.WriteLine("Now that you are in the theatre, you need to find your friends. Theatre has 20 rows, type a number to check that row.");
            int rowGuess = Convert.ToInt32(Console.ReadLine());

            bool isCorrectRow = rowGuess == 9;
            do
            {
                switch (rowGuess)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("You are pretty cold.  Keep looking!");
                        rowGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 10:
                    case 11:
                    case 12:
                        Console.WriteLine("You are red hot.  Keep looking!");
                        rowGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        Console.WriteLine("You are very cold.  Keep looking!");
                        rowGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Yea! You found your friends, just in time for the movie to start.");
                        isCorrectRow = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid row number. Please enter a number 1-20.");
                        break;
                }
            }
            while (!isCorrectRow);

            Console.Read();
        }
    }
}
