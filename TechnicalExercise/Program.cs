using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Applying some programming techniques
 *  in C#.
 *  
 *  * if-else statement to return true or false
 *    based on if value is greater than 2.
 *  * switch statement with 3 cases + default.
 *  * random number usage.
 */

namespace TechnicalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool trueFalse = false;
            var valueTF = 0;
            string[] electricCars = new string[3] { "tesla", "toyota", "nissan" };
            string yesNo;
            string choice;

            // Introduction
            Console.WriteLine(Stars(100));
            Console.WriteLine("Let's talk about big purchases.\n" +
                "How many years have you been saving money? ");
            Console.WriteLine(Stars(100));

            // Handle errors
            try
            {
                // Prompting for number of years money has been saved
                valueTF = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nSo you've been saving for {valueTF} year(s).\n\n");
                if (valueTF >= 2)
                {
                    trueFalse = true;
                    Console.WriteLine(BigPurchase(valueTF, trueFalse));
                }
                else
                {
                    Console.WriteLine(BigPurchase(valueTF, trueFalse));
                }
                Console.WriteLine("Press ENTER to continue..."); // Allow user to read text
                Console.ReadLine();
            }
            catch (Exception why)
            {
                // Present a hopefully useful message
                Console.WriteLine($"You caused an error with your input...\n{why.Message}");
            }

            // Get user's opinion
            Console.Write("Do you want to get an electric vehicle? ");
            yesNo = Console.ReadLine();

            // Attempting to catch further errors..
            try
            {
                if (yesNo.ToLower() == "yes")
                {
                    Console.WriteLine("\nYou have a few options. " +
                        "Which make of car would you like?\n" +
                        "Options include Tesla, Nissan, Toyota..");
                    choice = Console.ReadLine().ToLower();

                    foreach (string car in electricCars)
                    {
                        if (choice == car)
                        {
                            carMake(choice);
                            break;
                        }
                        else
                        {
                            carMake(choice);
                            break;
                        }
                    }
                    // Display lottery winning
                    // Show lottery winning even if user doesn't initially want electric vehicle
                    Console.WriteLine(Stars(100));
                    Console.WriteLine(LotteryWin());
                    Console.WriteLine(Stars(100));
                    Console.WriteLine("\n\n\n");
                }
                else if (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
                {
                    Console.WriteLine("That is an invalid choice.");
                }
                else
                {
                    Console.WriteLine("I see.  Well you have plenty of options out there!");
                }
            }
            catch (Exception wrong)
            {
                Console.WriteLine($"Your input caused an error.\n{wrong.Message}");
            }
        }
        // Method for case switch statement
        public static void carMake(string choice)
        {
            string option;
            switch (choice)
            {
                case "tesla":
                    option = $"Lucky for you!  " +
                        $"{FirstCharUpperCase(choice)} " +
                        $"has only electric vehicles!";
                    break;
                case "toyota":
                    option = $"{FirstCharUpperCase(choice)} " +
                        $"is a good company.  They're currently" +
                        $" working on electric vehicles!";
                    break;
                case "nissan":
                    option = $"{FirstCharUpperCase(choice)} " +
                        $"should have at least one" +
                        $" electric vehicle!";
                    break;
                default:
                    Console.WriteLine("Not sure about that company. " +
                        " Try to research it!");
                    return;
            }
            Console.WriteLine($"\n{option}\n\n");
        }

        // Method for random lottery winnings
        public static string LotteryWin()
        {
            Random lotteryChance = new Random();
            int[] lotteryTotals = new int[] { 10000, 15000, 20000 };
            int lottery = lotteryChance.Next(0, lotteryTotals.Length);

            string lotteryMessage = ($"This is your lucky day!\n\n" +
                        $"If you decide to get an electric vehicle," +
                        $" then you are eligible for ${lotteryTotals[lottery]} " +
                        $"off the total price!!!");

            return lotteryMessage;
        }

        // Method for giving advice on purchasing a vehicle
        public static string BigPurchase(int valueTF, bool trueFalse)
        {
            string advice;

            if (valueTF >= 2)
            {
                advice = ($"True or False: If I have been saving " +
                        $"money for {valueTF} years, then am I able to " +
                        $"buy a new vehicle?\n\n{trueFalse}.\n\n" +
                        $"You might be able to save extra money today!\n");
            }
            else
            {
                advice = ($"True or False: If I have been saving " +
                        $"money for {valueTF} years, then am I able to " +
                        $"buy a new vehicle?\n\n{trueFalse}.\n\n" +
                        $"That might change with today's offer.\n");
            }
            return advice;
        }

        // Method for converting first char to uppercase
        public static string FirstCharUpperCase(string choice)
        {
            return char.ToUpper(choice[0]) + choice.Substring(1);
        }

        // Add stars to separate the text
        static string Stars(int n)
        {
            return new string('*', n);
        }
    }
}
