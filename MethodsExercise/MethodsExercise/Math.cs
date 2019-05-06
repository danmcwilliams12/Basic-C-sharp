using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Math
    {
        public int Number { get; set; }

        public static Math AddTwo(Math m)
        {
            int newNumber = m.Number + 2;
            m.Number = newNumber;

            return m;
        }
        public static Math TimesFive(Math m)
        {
            int newNumber = m.Number * 5;
            m.Number = newNumber;

            return m;
        }
        public static Math MinusSeven(Math m)
        {
            int newNumber = m.Number - 7;
            m.Number = newNumber;
            return m;
        }
    }
}
