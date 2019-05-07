using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 1 };
            Employee employee2 = new Employee() { Id = 2 };
            bool isEqual = (employee1 == employee2);
            Console.WriteLine(isEqual.ToString());
            Console.ReadLine();
        }
    }
}
