using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal Hourly1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeklyHours1 = Convert.ToInt32(Console.ReadLine());
            decimal weeklyPay1 = Hourly1 * weeklyHours1;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            decimal Hourly2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeklyHours2 = Convert.ToInt32(Console.ReadLine());
            decimal weeklyPay2 = Hourly2 * weeklyHours2;
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(weeklyPay1);
            Console.WriteLine("Weekly salary of Person 2");
            Console.WriteLine(weeklyPay2);
            bool isGreater = weeklyPay1 > weeklyPay2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(isGreater.ToString());
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

        }
    }
}
