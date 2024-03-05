using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int _Sum;
        private List<int> _DieList = new List<int>(); //List required mainly for testing purposes as I need access to each dice roll from outside this class

        //Properties
        public int Sum
        {
            get { return _Sum; }
            set { _Sum = value; }
        }
        public List<int> DieList
        {
            get { return _DieList; }
            set { _DieList = value; }
        }

        //Methods
        //Creates an object of class Die, rolls it and adds it to a list
        public void CreateDice()
        {
            Die dice = new Die();
            DieList.Add(dice.RollDice());
        }

        //Goes through each item in the list and adds them together
        public int CalcSum()
        {
            foreach (int dice in DieList)
            {
                Sum += dice;
            }
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
            foreach (int i in DieList)
            {
                Console.WriteLine($"Roll of die {count} is {i}");
                count++;
            }
        }

    }
}