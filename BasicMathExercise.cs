using System;


namespace BasicMathExersice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type a number...");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double product = num1 * 50;
            Console.WriteLine("Your number times fifty eauals: " + product.ToString());
            Console.WriteLine("How about another number...");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double total = num2 + 25;
            Console.WriteLine("Your number plus tewnty-five equals: " + total.ToString());
            Console.WriteLine("Can I have a third number please?");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double quotient = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 equals: " + quotient.ToString());
            Console.WriteLine("Please provide another number...");
            double num4 = Convert.ToDouble(Console.ReadLine());
            bool isGreaterThanFifty = num4 > 50;
            if (isGreaterThanFifty)
            {
                Console.WriteLine("Your number is greater than fifty!");
            }
            else
            {
                Console.WriteLine("Your number is less than fifty!");
            };
            Console.WriteLine("Finally, provide one last number...");
            double num5 = Convert.ToDouble(Console.ReadLine());
            double remainder = num5 % 7;
            Console.WriteLine("Your number divided by seven has a remainder of: " + remainder.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
