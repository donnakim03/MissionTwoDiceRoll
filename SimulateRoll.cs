using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionTwoDiceRoll
{
    internal class SimulateRoll
    {
        // method to roll dice
        public static int[] Roll(int nRolls)
        {
            Random rnd = new Random(); // to produce random number

            // index 0 is for a roll of 2, index 1 is for a roll of 3, index 2 is for a roll of 4, etc.
            int[] rollsResult = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; // array of ints to hold results

            // for loop to roll the dice the amount of times the user inputs
            for (int i = 0; i < nRolls; i++)
            {
                //generate random number from 1 through 6
                int rollNumber1 = rnd.Next(1, 7); // first die
                int rollNumber2 = rnd.Next(1, 7); // second die

                int rollTotal = rollNumber1 + rollNumber2; // add two dice to get the total for this roll

                rollsResult[rollTotal - 2] = rollsResult[rollTotal - 2] + 1; // add 1 to the total roll position in the array that keeps track of the result
            }

            return rollsResult; // return the array with the result of total rolls for each roll total (2-12)
        }
    }
}
