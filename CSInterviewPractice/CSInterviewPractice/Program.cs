using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to total the odd numbers

            int OddAdder(int[] array)
            {
                int total = 0;
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        total += array[i];
                    }
                }
                return total;
            }
            int[] testArray = { 1, 2, -3, 0 };
            Console.WriteLine("Problem 1 \nExpected Result: -2");
            Console.WriteLine("Actual Result: "+ OddAdder(testArray));
            Console.ReadKey();

            //Given an array of integers, write a method to sum the elements in the array,
            //knowing that some of the elements may be very large integers.

            long SumLargeNums(long[] array)
            {
                long total = 0;
                for (var i = 0; i < array.Length; i++)
                {
                    total += array[i];
                }
                return total;
            }

            long[] testArray2 = { 300000, 4500000000000, 5400000000000 };

            Console.WriteLine("Problem 2 \nExpected Result: 9900000300000");
            Console.WriteLine("Actual Result: " + SumLargeNums(testArray2));
            Console.ReadKey();

            //Given a string, reverse it

            string ReverseString(string chars)
            {
                char[] charArray = chars.ToCharArray();
                Array.Reverse(charArray, 0 , charArray.Length);
                string final = new string(charArray);
                return final;
            }
            string testString = "This string should be reversed";

            Console.WriteLine("Problem 3 \nExpected Result: desrever eb dluohs gnirts sihT");
            Console.WriteLine("Actual Result: " + ReverseString(testString));
            Console.ReadKey();

            //Given a string, remove any repeated letters.

            string RemoveRepeated(string chars)
            {
                int n = 0;
                string noRepeats = "";
                for (var i = 0; i < chars.Length; i++)
                {
                    if (!noRepeats.Contains(chars[i]) || chars[i].ToString() == " ")
                    { 
                        noRepeats = noRepeats.Insert(n, chars[i].ToString());                       
                        n++;
                    }                
                }
                return noRepeats;
            }

            string testString2 = "remove repeated letters";

            Console.WriteLine("Problem 4 \nExpected Result: remov patd ls");
            Console.WriteLine("Actual Result: " + RemoveRepeated(testString2));
            Console.ReadKey();

            //FizzBuzz

            for (int num = 1; num < 101; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadKey();
        }
    }
}
