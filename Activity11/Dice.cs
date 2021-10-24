using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    class Dice
    {
        // Declare variables
        private int sidesCount;

        // Created instance to generate random numbers.
        Random rand = new Random();

        // Method returns how many sides each die has.
        public int SetSides()
        {
            sidesCount = 6;

            return sidesCount;
        }

        // Method rolls die and returns a random number between 1 and 6.
        public int RollDie()
        {
            int side = rand.Next(1, 6);

            return side;
        }

        // Method checks if die 1 and die 2 are equal to 1. Otherwise returns false.
        public bool SnakeEyes(int num1, int num2)
        {
            if (num1 == 1 && num2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
