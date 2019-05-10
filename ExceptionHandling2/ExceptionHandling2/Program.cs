using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            //will loop until valid input is received
            bool isSuccessful = false;
            while (!isSuccessful)
            {
                try
                {
                    int age = 0;
                    bool validAge = false;
                    Console.WriteLine("How old are you?");
                    validAge = int.TryParse(Console.ReadLine(), out age);
                    //if user enters 0
                    if (age == 0 && validAge == true)
                    {                            
                        throw new ZeroAgeException();
                    }
                    //if user enters negative integer
                    else if (age < 0)
                    {
                        throw new NegativeIntException();
                    }
                    //if parse was unsuccessful
                    else if (!validAge)
                    {
                        throw new Exception();
                    }
                    //if input is valid
                    else
                    {
                        //create DateTime object
                        var dateTime = DateTime.Now;
                        //create variable equal to current year
                        var currentYear = dateTime.Year;
                        //accounts for the 2 years the user could have been born in
                        Console.WriteLine("You were born in the year " + (currentYear - age) + " or " + (currentYear - (age + 1)) + ".");
                        //loop exit condition
                        isSuccessful = true;
                        Console.ReadLine();
                    }                                                          
                }
                catch (ZeroAgeException)
                {
                    Console.WriteLine("Your age cannot be zero. Please enter a positive integer.");                   
                }
                catch (NegativeIntException)
                {
                    Console.WriteLine("Your age cannot be negative. Please enter a positive integer.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Only enter whole numbers to represent your age.");
                }

            }

        }
    }
}
