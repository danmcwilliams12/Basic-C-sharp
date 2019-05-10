using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //this will always evaluate to true no matter what
            const bool daTruth = true;

            //example of var saving typing in an appropriate context
            var myList = new List<string>()
            {
                "Apples",
                "Tomatoes",
                "Bread",
                "Milk",
                "Pasta"
            };            

            //instantiating a student object with chined constructors
            var newStudent = new Student("James", 1);
            //pauses program for debugging
            Console.ReadLine();
        }
    }
}
