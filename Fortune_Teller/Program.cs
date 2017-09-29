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

            string firstName;
            string lastName;
            string age;
            int iAge = 0;
            string birthMonth;
            int iBirthMonth = 0;
            string favoriteColor;
            string numSibs;
            int iNumSibs = 0;

            Console.WriteLine("I'm a fortune teller, of sorts.");
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine().Trim();
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
                Environment.Exit(0);
            }

            Console.WriteLine("Good, good. What's your last name?");
            lastName = Console.ReadLine().Trim();
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
                Environment.Exit(0);
            }

            Console.WriteLine("Interesting! What is your age?");
            age = Console.ReadLine().Trim();
            if (age.ToLower() == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
                Environment.Exit(0);
            }
            else
            {
                iAge = int.Parse(age);
            }

            Console.WriteLine("You don't say! Say, what's your birth month, by number?");
            Console.WriteLine("(Like, \"1\" for \"January,\" and so on.)");
            birthMonth = (Console.ReadLine().Trim());
            if (birthMonth.ToLower() == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
                Environment.Exit(0);
            }
            else
            {
                iBirthMonth = int.Parse(birthMonth);
            }

            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("I can help if you type \"help\".");
            favoriteColor = Console.ReadLine().ToLower().Trim();
            if (favoriteColor == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
                Environment.Exit(0);
            }
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
                if (favoriteColor == "quit")
                {
                    Console.WriteLine("No one likes a quitter...");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Phew, that's a lot! One last one: how many siblings do you have?");
            numSibs = (Console.ReadLine());
            if (numSibs.ToLower() == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
                Environment.Exit(0);
            }
            else
            {
                iNumSibs = int.Parse(numSibs);
            }


            //Years to retirement assignment
            int yearsToRetire;
            if (iAge % 2 == 0)
            {
                yearsToRetire = 14;
            }
            else
            {
                yearsToRetire = 2147483647;
            }

            //Vacation home assignment
            string vacationHome;
            if (iNumSibs == 0)
            {
                vacationHome = "nowhere special, just Cabo San Lucas";
            }
            else if (iNumSibs == 1)
            {
                vacationHome = "in a Lake Erie undersea palace";
            }
            else if (iNumSibs == 2)
            {
                vacationHome = "on scenic the Moon";
            }
            else if (iNumSibs == 3)
            {
                vacationHome = "of a really big bouncy house";
            }
            else if (iNumSibs > 3)
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
                transit = "a sweet Caddy";
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

            if (iBirthMonth >= 1 && iBirthMonth < 5)
            {
                moneyBank = 100000.00;
            }

            else if (iBirthMonth >= 5 && iBirthMonth < 9)
            {
                moneyBank = 200000.00;
            }

            else if (iBirthMonth >= 9 && iBirthMonth < 13)
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

