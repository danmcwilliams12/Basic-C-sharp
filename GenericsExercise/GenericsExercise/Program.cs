using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Dog", "House", "Lawn", "Fan" };
            

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 3, 7, 12, 3 };

            foreach (string thing1 in employee.Things)
            {
                Console.WriteLine(thing1);               
            }
            foreach (int thing2 in employee2.Things)
            {
                Console.WriteLine(thing2);
            }
            Console.ReadLine();


        }
    }
}
