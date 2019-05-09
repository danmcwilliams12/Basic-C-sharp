using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string userNumber = Console.ReadLine().ToString();
            File.WriteAllText(@"C:\Users\danie\Logs\FileIOExercise.txt", userNumber);
            Console.WriteLine("Your numbers so far...");
            Console.WriteLine(File.ReadAllText(@"C:\Users\danie\Logs\FileIOExercise.txt"));
            Console.ReadLine();
        }
    }
}
