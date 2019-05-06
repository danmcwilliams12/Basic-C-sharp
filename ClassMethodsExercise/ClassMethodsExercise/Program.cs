using System;

namespace ClassMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondResult = 0;

            Math math = new Math();
            Console.WriteLine("Enter a number to be divided by 2");
            math.Number = Convert.ToInt32(Console.ReadLine());

            //math.DivideByTwo();
            math.DivideByTwo(out secondResult);

            Console.WriteLine("Result: "+math.Number);
            Console.WriteLine("Result times 5 equals: "+secondResult);
            Console.ReadLine();
        }
    }
}
