using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new DateTime ogject
            DateTime currentDate = new DateTime();
            //Assign current DateTime to the object
            currentDate = DateTime.Now;
            //Print DateTime to Console
            Console.WriteLine("Current date and time: "+currentDate);
            Console.ReadLine();

            Console.WriteLine("Enter a number...");
            double numberToAdd = Convert.ToDouble(Console.ReadLine());
            //reset value so exact time is modified
            currentDate = DateTime.Now;
            //add x hours to currentDate
            Console.WriteLine("Adding your number in hours to the current time would make it: " +currentDate.AddHours(numberToAdd));
            Console.ReadLine();
        }
    }
}
