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
        private List<Die> _DieList = new List<Die>(); //List required mainly for testing purposes as I need access to each dice roll from outside this class
        //Properties
        public int Sum {get; set; } //Property definition improvement from the review process
        public List<Die> DieList //This property still has to be formatted as such otherwise, null exception errors occur
        {
            get { return _DieList; }
            set { _DieList = value; }
        }


        //Methods
        //Creates an object of class Die adds it to a list
        public void CreateDice()
        {
            Die dice = new Die();
            dice.RollDice();
            DieList.Add(dice);
        }

        //Goes through each item in the list and adds them together
        public int CalcSum()
        {
            foreach (Die dice in DieList)
            {
                Sum += dice.Roll;
            }
            //Print statement moved here as pointed out by a reviewer that the brief specifies it should be here
            Console.WriteLine($"The sum of all of the dice rolls is {Sum}");
            return Sum;
        }

        //Prints sum of dice roll
        //Created a separate method as calling CalcSum() multiple times incorrectly recalculates the sum of dice
        public int PrintSum()
        {
            return Sum;
        }

        //Prints the information to the user of what each die rolled
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
