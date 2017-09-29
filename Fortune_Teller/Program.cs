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
            // Part 1, initializes variables, prompts user and assigns. 

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
            favoriteColor = Console.ReadLine().ToLower().Trim();
            if (favoriteColor == "help")
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
                favoriteColor = Console.ReadLine().ToLower().Trim();
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

            //Vacation home assignment
            string vacationHome;
            if (numSibs == 0)
            {
                vacationHome = "nowhere special, just Cabo San Lucas";
            }
            else if (numSibs == 1)
            {
                vacationHome = "in an underlake palace in Lake Erie";
            }
            else if (numSibs == 2)
            {
                vacationHome = "on scenic the Moon";
            }
            else if (numSibs == 3)
            {
                vacationHome = "of a really big bouncy house";
            }
            else if (numSibs > 3)
            {
                vacationHome = "near Sting's house, wherever that is,";
            }
            else
            {
                vacationHome = "on a rapidly melting arctic glacier";
            }

            //Assigns mode of transportation based on ROYGBIV preference
            string transit;
            if (favoriteColor == "r" || favoriteColor == "red")
            {
                transit = "rocket boots";
            }

            else if (favoriteColor == "o" || favoriteColor == "orange")
            {
                transit = "a Caddy";
            }

            else if (favoriteColor == "y" || favoriteColor == "yellow")
            {
                transit = "some European luxury car";
            }

            else if (favoriteColor == "g" || favoriteColor == "green")
            {
                transit = "a hanglider";
            }

            else if (favoriteColor == "b" || favoriteColor == "blue")
            {
                transit = "a flock of cats conveying you like some baron";
            }

            else if (favoriteColor == "i" || favoriteColor == "indigo")
            {
                transit = "Santa's sleigh";
            }

            else if (favoriteColor == "v" || favoriteColor == "violet")
            {
                transit = "Chuck D's Oldsmobile 88";
            }

            else
            {
                transit = "some beat up old Chuck Taylor All Stars";
            }

            // Uses birth month to assign $ in the bank
            double moneyBank;

            if (birthMonth >= 1 && birthMonth < 5)
            {
                moneyBank = 100000.00;
            }

            else if (birthMonth >= 5 && birthMonth < 9)
            {
                moneyBank = 200000.00;
            }

            else if (birthMonth >= 9 && birthMonth < 13)
            {
                moneyBank = 300000.00;
            }

            else
            {
                moneyBank = 0.00;
            }

            //Writes fortune                           
            Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, \na vacation home {4} and {5}.", firstName, lastName, yearsToRetire, moneyBank, vacationHome, transit);


        }

    }

}

