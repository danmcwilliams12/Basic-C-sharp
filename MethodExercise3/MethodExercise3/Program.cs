using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number...");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number if you wish.  If not leave blank.");
            string input2 = Console.ReadLine();           
            if (input2 == "")
            {
                Console.WriteLine(Math.AddTogether(input1));
            }
            else
            {
                Console.WriteLine(Math.AddTogether(input1, Convert.ToInt32(input2)));
            }                       

            Console.ReadLine();
        }   
    }
}
