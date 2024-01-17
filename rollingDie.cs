using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//created second class according to the instructions that take the input from the user of how many times the dice will be rolled and then this class simulates actually rolling the dice and returns an array of the results of the dice rolling
namespace Mission2
{
    internal class rollingDie
    {
        //creating the method that takes the number of rolls passed from the other class
        public static int[] RollDie(int numberOfRolls)
        {
            //brings in random to be used for the dice
            Random random = new Random();
            int[] results = new int[numberOfRolls];

            //a loop that takes the number of rolls the person is doing and rolls them for that amount of times
            for (int iCount = 0; iCount < numberOfRolls; iCount++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                //array of the resuts of each dice combined to total the total roll number for each row
                results[iCount] = dice1 + dice2;
            }

            //returns the results to be given back to the first class to be able to create the hitogram later
            return results;
        }
    }
}
