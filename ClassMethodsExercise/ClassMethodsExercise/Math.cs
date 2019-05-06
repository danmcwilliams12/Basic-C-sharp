using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsExercise
{
    class Math
    {
        public int Number { get; set; }


        public void DivideByTwo()
        {
            Number /= 2;
        }

        public void DivideByTwo(out int secondResult)
        {           
            DivideByTwo();
            secondResult = Number * 5;
        }
    }
}
