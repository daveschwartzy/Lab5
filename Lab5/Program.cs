using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {

        static void Main(string[] args)
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("This program will roll two dice and display the results of each for you.");
                DoAgain();
                int sides = DiceSides("Please enter the number of sides for a pair of dice.");
                Console.WriteLine($"You chose {sides} sides.");
                int die1 = RollDie.Next(1, sides);
                Console.WriteLine($"Die 1 rolled {die1}");
                int die2 = RollDie.Next(1, sides);
                Console.WriteLine($"Die 2 rolled {die2}");
                DoAgain2();
            }
        }
        public static int DiceSides(string sides)
        {
            Console.WriteLine(sides);
            bool valid = false;

            int n = 0;
            while (!valid)
            {
                string input1 = Console.ReadLine();

                valid = int.TryParse(input1, out n);

                if (n < 2)
                {
                    Console.WriteLine("That's not valid input. Please try again.");
                    valid = false;
                }
            }

            return n;
        }
        public static bool DoAgain2()
        {
            Console.WriteLine("Would you like to run this program again? (Yes/No)");
            string repeat = Console.ReadLine().ToLower();
            if (repeat == "yes" || repeat == "y" || repeat == "yeah" || repeat == "yep")
            {

            }
            else
            {

                Environment.Exit(0);
            }
            return true;
        }
        public static bool DoAgain()
        {
            Console.WriteLine("Would you like to roll the die? (Yes/No)");
            string repeat = Console.ReadLine().ToLower();
            if (repeat == "yes" || repeat == "y" || repeat == "yeah" || repeat == "yep")
            {

            }
            else
            {

                Environment.Exit(0);
            }
            return true;
        }
        public static Random RollDie = new Random();

        public static int Roll(int n)
        {
            int result = RollDie.Next(1, n + 1);
            return result;
        }
    }
}

