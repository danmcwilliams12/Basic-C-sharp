using System;


namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            Console.WriteLine("What is the width of your package?");
            decimal width = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the height of your package?");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the length of your package?");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            decimal totalDemensions = width + height + length;
            if (totalDemensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }
            decimal quoteTotal = Math.Round((totalDemensions * weight) / 100, 2);
            Console.WriteLine("Your package will ship for approximately " + quoteTotal + " dollars.");
            Console.Read();
        }
    }
}
