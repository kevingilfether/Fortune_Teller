using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {

            //https://www.youtube.com/watch?v=tnCCg3U0tHA
            // Part 1, initializes variables, prompts user and 

            bool quitFlag = false;
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favoriteColor;
            int numSibs;

            Console.WriteLine("I'm a fortune teller, of sorts.");
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine().Trim();
            
            Console.WriteLine("Good, good. What's your last name?");
            lastName = Console.ReadLine().Trim();

            Console.WriteLine("Interesting! What is your age?");
            age = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("You don't say! Say, what's your birth month, by number?");
            Console.WriteLine("(Like, \"1\" for \"January,\" and so on.)");
            birthMonth = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("I can help if you type \"help\".");
            favoriteColor = Console.ReadLine().Trim();
            if (favoriteColor.ToLower() == "help")
            {
                //ROYGBIV Help Console and extra prompt
                Console.WriteLine("R = Red");
                Console.WriteLine("O = Orange");
                Console.WriteLine("Y = Yellow");
                Console.WriteLine("G = Green");
                Console.WriteLine("B = Blue");
                Console.WriteLine("I = Indigo");
                Console.WriteLine("V = Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                favoriteColor = Console.ReadLine().Trim();
            }

            Console.WriteLine("Phew, that's a lot! One last one: how many siblings do you have?");
            numSibs = int.Parse(Console.ReadLine());

            //Years to retirement assignment
            int yearsToRetire;
            if (age % 2 == 0)
            {
                yearsToRetire = 14;
            }
            else
            {
                yearsToRetire = 2147483647;
            }
            Console.WriteLine(yearsToRetire);

            //Vacation home assignment
            



        }

    }
}

