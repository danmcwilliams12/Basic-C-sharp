using System;
using System.Text;

namespace StringMethodsExersice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the text-o-matic 3000! I can do all sorts of text manipulation.");
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Ok then, what is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("And finally, what is your favorite number?");
            string favNum = Console.ReadLine();
            string favAll = "";
            int animalLength = favAnimal.Length;
            if (Convert.ToInt32(favNum) == 1)
            {
                favAll = favNum + " " + favColor + " " + favAnimal;
            }
            else if (Convert.ToInt32(favNum) > 1 && favAnimal.EndsWith("ey") || favAnimal.EndsWith("ay") || favAnimal.EndsWith("oy"))
            {

                string EYAnimal = favAnimal.Insert((animalLength), "s");
                favAll = favNum + " " + favColor + " " + EYAnimal;
            }
            else if (Convert.ToInt32(favNum) > 1 && favAnimal.EndsWith("y"))
            {
                string YAnimal = favAnimal.TrimEnd('y').Insert((animalLength - 1), "ies");
                favAll = favNum + " " + favColor + " " + YAnimal;
            }
            else if (Convert.ToInt32(favNum) > 1 && favAnimal.EndsWith("s") || favAnimal.EndsWith("h") || favAnimal.EndsWith("o") || favAnimal.EndsWith("x") || favAnimal.EndsWith("z"))
            {
                string SHOXZAnimal = favAnimal.Insert((animalLength), "es");
                favAll = favNum + " " + favColor + " " + SHOXZAnimal;
            }
            else if (Convert.ToInt32(favNum) > 1 && favAnimal.EndsWith("fe"))
            {
                string FEAnimal = favAnimal.TrimEnd('e').TrimEnd('f').Insert((animalLength - 2), "ves");
                favAll = favNum + " " + favColor + " " + FEAnimal;
            }
            else if (Convert.ToInt32(favNum) > 1 && favAnimal.EndsWith("f"))
            {
                string FAnimal = favAnimal.TrimEnd('f').Insert((animalLength - 1), "ves");
                favAll = favNum + " " + favColor + " " + FAnimal;
            }
            else
            {
                string elseAnimal = favAnimal.Insert((animalLength), "s");
                favAll = favNum + " " + favColor + " " + elseAnimal;
            }
            Console.WriteLine("If you like those things then you will love " + favAll + "!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("For my next trick I will turn a sentence that you write in to all uppercase characters. Type away!");
            string sentence = Console.ReadLine();
            string newString = sentence.ToUpper();
            Console.WriteLine(newString);
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Ok, finally I will combine a couple sentences together to make a paragraph.\nType a sentence to combine with the one you already typed.");
            string sentence2 = Console.ReadLine();
            StringBuilder sb = new StringBuilder(sentence);
            sb.Append(" ").Append(sentence2);            
            Console.WriteLine(sb);
            Console.WriteLine("One more sentence to finish off the paragraph.");
            string sentence3 = Console.ReadLine();
            sb.Append(" ").Append(sentence3);
            Console.WriteLine(sb);
            Console.Read();

        }
    }
}
