using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string currentDay = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek) Enum.Parse(typeof(DaysOfTheWeek), currentDay.ToLower());       
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();                            
        }
    }
    public enum DaysOfTheWeek
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
}
