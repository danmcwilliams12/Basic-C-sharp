using System;


namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            string hasDUI = "";

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Answer \"yes\" or \"no\".");
            while (hasDUI == "")
            {

                hasDUI = Console.ReadLine().ToLower();
                if (hasDUI != "yes" && hasDUI != "no")
                {
                    Console.WriteLine("Please respond with \"yes\" or \"no\".");
                    hasDUI = "";
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = (age > 15 && hasDUI == "no" && numTickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified.ToString());
            Console.WriteLine("Press Enter to continue...");
            Console.Read();
        }
    }
}
