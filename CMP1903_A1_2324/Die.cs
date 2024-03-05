using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        //Variables
        private int _Roll;

        //Property
        public int Roll
        {
            get { return _Roll; }
            set { _Roll = value; }
        }
        //Method
        private static Random roll = new Random();
        public int RollDice()
        {
            Roll = roll.Next(1, 6);
            return Roll;
        }
    }
}
