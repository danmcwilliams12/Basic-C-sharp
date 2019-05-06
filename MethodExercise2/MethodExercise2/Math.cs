using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    class Math
    {
        public static int DoStuff(int num)
        {
            return num -= 10;          
        }
        public static int DoStuff(decimal num)
        {     
            return (Convert.ToInt32(num) / 3);
        }
        public static int DoStuff(string num)
        {
            return (Convert.ToInt32(num) * 7);
        }
    }
}