using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExercise
{
    class Program
    {
        static void Main()
        {
            List<int> numList = new List<int> { 3, 5, 12, 2, 7, 9, 1, 6, 15 };
            Console.WriteLine("I have a list of numbers here.  Please enter a number and I will divide each number in the list by it.");

            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numList)
                {
                    int tempNum = number / userNum;
                    Console.WriteLine("\n" + tempNum);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You may not divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a whole number!");
            }           
                Console.WriteLine("The program has emerged from the try catch block.");
                Console.ReadLine();                                   
        }
    }
}
