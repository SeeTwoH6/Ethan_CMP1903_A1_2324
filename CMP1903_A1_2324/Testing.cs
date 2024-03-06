using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void Check()
        {
            Console.WriteLine("Testing die class...");
            Die testDice = new Die();
            testDice.RollDice();
            Debug.Assert(testDice.Roll > 0 && testDice.Roll < 7, "Rolls were not within the expected range");
            Console.WriteLine("Rolls are confirmed to be within [1,6]");

            Console.WriteLine("Testing game class...");
            Game testGame = new Game();
          
            //Using for loops to create a sample game.
            //Testing with a game of 5 dice
            for (int i = 0; i < 5; i++)
            {
                testGame.CreateDice();
            }
            testGame.CalcSum();
            //Used 5*1 and 5*6 because these are the respective min and max values a game could result in
            Debug.Assert(testGame.PrintSum() >= 5 * 1 && testGame.PrintSum() <= 5 * 6, "The sum totalled to an unexpected value");
            Console.WriteLine("The sum of the test game were within acceptable parameters");
        }
    }
}
