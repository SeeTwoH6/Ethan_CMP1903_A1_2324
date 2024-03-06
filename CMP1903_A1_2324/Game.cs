using System;
using System.Collections.Generic;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        //Variables
        private List<Die> DieList = new List<Die>(); //List required mainly for testing purposes as I need access to each dice roll from outside this class
        private int sum = 0;


        //Methods
        /// <summary>
        /// Creates an object of class Die adds it to a list
        /// </summary>
        public void CreateDice()
        {
            Die dice = new Die();
            dice.RollDice();
            DieList.Add(dice);
        }

        /// <summary>
        /// Goes through each item in the list and adds them together
        /// </summary>
        /// <returns>A single integer holding the sum of all dice rolls</returns>
        public int CalcSum()
        {
            foreach (Die dice in DieList)
            {
                sum += dice.Roll;
            }
            //Print statement moved here as pointed out by a reviewer that the brief specifies it should be here
            Console.WriteLine($"The sum of all of the dice rolls is {sum}");
            return sum;
        }

        //Created a separate method as calling CalcSum() multiple times incorrectly recalculates the sum of dice
        /// <summary>
        /// Prints sum of dice roll
        /// </summary>
        /// <returns>The previously calculated sum of rolls</returns>
        public int PrintSum()
        {
            return sum;
        }

        /// <summary>
        /// Prints the information to the user of what each die rolled
        /// </summary>
        public void PrintDice()
        {
            int count = 1;
            foreach (Die dice in DieList)
            {
                Console.WriteLine($"Roll of die {count} is {dice.Roll}");
                count++;
            }
        }

    }
}
