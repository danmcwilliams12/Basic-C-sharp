using System;
using System.Collections.Generic;

namespace ArraysListsExercise
{
    class Program
    {
        static void Main()
        {
            string errorMessage = "That is an invalid number.  Please try again!";
            string[] idArray = { "tinker", "taylor", "soldier", "spy" };


            Console.WriteLine("Type a number between 1 and 4 to reveal your espianoge identity.");
            int userIDCheck = Convert.ToInt32(Console.ReadLine());
            while (userIDCheck > 4 || userIDCheck < 1)
            {
                Console.WriteLine(errorMessage);
                userIDCheck = Convert.ToInt32(Console.ReadLine());
            }
            string userIDFinal = idArray[userIDCheck - 1];
            Console.WriteLine("Your true identity is: " + userIDFinal);

            int[] intArray = { 4, 7, 19, 354, 64, 0, 2 };
            Console.WriteLine("Now type a number between 1 and 7 to retrieve a lucky number.");

            int luckyNumCheck = Convert.ToInt32(Console.ReadLine());
            while (luckyNumCheck > 7 || luckyNumCheck < 1)
            {
                Console.WriteLine(errorMessage);
                luckyNumCheck = Convert.ToInt32(Console.ReadLine());
            }
            string luckyNum = intArray[luckyNumCheck - 1].ToString();
            Console.WriteLine("Your new lucky number is: " + luckyNum);

            List<string> stringList = new List<string>();
            stringList.Add("Tom");
            stringList.Add("Jane");
            stringList.Add("Bill");
            stringList.Add("Sarah");
            stringList.Add("Tyreek");
            stringList.Add("Sally");
            stringList.Add("LeBron");
            stringList.Add("Tamantha");

            Console.WriteLine("Finally type a number between 1 and 8 to get your new name.");
            int newNameCheck = Convert.ToInt32(Console.ReadLine());
            while (newNameCheck > 8 || newNameCheck < 1)
            {
                Console.WriteLine(errorMessage);
                newNameCheck = Convert.ToInt32(Console.ReadLine());
            }
            string newName = stringList[newNameCheck - 1].ToString();
            Console.WriteLine("Your new totally offical, no way you can change it back,\nreally seriously and permanently new name is:\n" + newName.ToUpper() + "!!!");
            Console.Read();
        }
    }
}
