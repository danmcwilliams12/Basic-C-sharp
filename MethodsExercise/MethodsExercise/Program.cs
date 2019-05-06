using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to perform math operations on.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Math math = new Math
            {
                Number = userInput
            };
            
            math = Math.AddTwo(math);
            Console.WriteLine(userInput+" plus two equals: "+math.Number);

            math.Number = userInput;
            math = Math.TimesFive(math);
            Console.WriteLine(userInput+" times five equals: "+math.Number);
            

            math.Number = userInput;
            math = Math.MinusSeven(math);
            Console.WriteLine(userInput + " minus seven equals: " + math.Number);
            //reset to input for future manipulation
            math.Number = userInput;
            Console.ReadLine();
        }
        
    }
    
}
