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
            int numberOfDice = 3; //Required so that the program can work for a variable number of dice
            for (int i = 0; i < numberOfDice; i++)
            {
                game.CreateDice();
            }
            game.PrintDice(); 
            game.CalcSum();
            Console.WriteLine($"The sum of all of the dice rolls is {game.PrintSum()}");

            //Creating and running an instance of the Testing class
            Testing checker = new Testing();
            checker.Check();
            Console.ReadLine();
        }
    }
}
