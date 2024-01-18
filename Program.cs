/*
 * Donna Kim
 * Section 3
 * Description: Simulate rolls of two 6 sided dice. Take user input for the number of rolls to simulate. Show result.
 */
using MissionTwoDiceRoll;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0; // variable to store number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!\n"); // Welcome user
        Console.WriteLine("How many dice rolls would you like to simulate?"); // Ask for number of rolls
        numRolls = int.Parse(Console.ReadLine()); // save number of rolls inputted by user

        // check if they entered a valid number of rolls (must be 1 or above)
        if (numRolls >= 1)
        {
            int[] results = SimulateRoll.Roll(numRolls); // roll the die and save the results from all rolls

            // comments to show the user
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + "\n");

            // for loop to print the results
            for (int i = 0; i < results.Length; i++)
            {
                // calculate percent rolled of total rolls
                double doubleNumRolls = numRolls;
                int percentRolled = Convert.ToInt32(Math.Round((results[i] / doubleNumRolls) * 100));

                // output of line recording each total for possible roll number (2-12)
                string resultOutput = (i + 2) + ": ";
                // for loop to print out the correct number of astericks (one asterick = one percent)
                for (int numAstericks = 0; numAstericks < percentRolled; numAstericks++)
                {
                    resultOutput = resultOutput + "*";
                }

                // print out the line
                Console.WriteLine(resultOutput);
            }
        }
        else
        {
            // if user inputs a number not 1 or higher
            Console.WriteLine("\nYou entered an invalid number of rolls.");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!"); // ending comment
    }
}