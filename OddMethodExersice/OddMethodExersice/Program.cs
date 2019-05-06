using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddMethodExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Math.StrangeMath(7, 4);

            Math.StrangeMath(num1: 4, num2: 6);
            Console.ReadLine();
        }
    }
}
