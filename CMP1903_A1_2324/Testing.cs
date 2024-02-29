using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            Debug.Assert(testDice.Roll > 0 && testDice.Roll < 7);
            Console.WriteLine("Rolls are confirmed to be within [1,6]");

            Console.WriteLine("Testing game class...");
            Game testGame = new Game();
            for (int i = 0; i < 5; i++)
            {
                testGame.CreateDice();
            }
            testGame.CalcSum();
            Debug.Assert(testGame.PrintSum() == testGame.DieList[0] + testGame.DieList[1] + testGame.DieList[2] + testGame.DieList[3] + testGame.DieList[4]);
            Console.WriteLine("The output of the PrintSum() method of the Game class is equal to the sum of the first die roll + ... + last die roll");
        }
    }
}
