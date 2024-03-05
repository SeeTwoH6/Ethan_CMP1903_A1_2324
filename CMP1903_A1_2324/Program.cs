using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            //Instantiating a new Game object
            Game game = new Game();
            while (true)
            {
                Console.WriteLine("Roll dice? (yes/no)");
                string answer = Console.ReadLine().ToLower(); //Converts all inputs to lower case
                if (answer.Length < 1) //Exception Handling - Guard Clause to catch empty strings
                {
                    Console.WriteLine("Please input a string");
                    continue;
                }
                else if (answer == "yes")
                {
                    game.CreateDice();
                }
                else if (answer == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input either 'yes' or 'no'");
                }
            }
            game.PrintDice();
            game.CalcSum();
            Console.WriteLine($"The sum of all of the dice rolls is {game.PrintSum()}");

            //Creating and running an instance of the Testing class
            if (game.PrintSum() > 0)
            {
                Testing checker = new Testing();
                checker.Check();
            }
            else
            {
                Console.WriteLine("No die were rolled, testing not required");
            }
            Console.ReadLine();
        }
    }
}