using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(Math.DoStuff(12));
            
            Math math2 = new Math();
            Console.WriteLine(Math.DoStuff(4.7m));

            Math math3 = new Math();
            Console.WriteLine(Math.DoStuff("4"));
            Console.ReadLine();

        }
    }
}
