//Ryan Hawkins, section 2
//This program simulates rolling two dice and keeps track of how many time each number is rolled with both dice. The user is able to input how many times they want to roll the dice.

using Mission2;

//first class as mentioned in the instructions
internal class Program
{
    //main method
    private static void Main(string[] args)
    {
        int numberRolls = 0;

        //starting the simulator and asking the user to input how many rolls they want
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine(" ");
        Console.WriteLine("How many dice rolls would you like to simulate? ");

        //reading the user input as a string for now but will later turn to integer and make sure it is an integer
        string input = Console.ReadLine();

        //checking to see if the user input was actually a valid integer. if it is, the simulator contines. if it is not, the simulator ends and tells the user there was an error
        if (int.TryParse(input, out numberRolls))
        {
            // If the user inputs a valid integer, numberRolls now contains the parsed integer value and the directions continue.
            Console.WriteLine(" ");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numberRolls);

            //array with the reults. this is where the other class and method are called with passing the variable that contains the number of rolls
            int[] results = rollingDie.RollDie(numberRolls);

            //this displays the histogram that is made in a method below
            DisplayHistogram(results);

            //last line to conclude the game after the results are shown
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        else
        {
            // If the user inputs an invalid integer, the simulation is not run and they are given an error message
            Console.WriteLine("Invalid input. That was not a valid number");
        }
    }

    //method to display the histogram with the results
    private static void DisplayHistogram(int[] results)
    {
        //array to store the counts for totals 2 to 12
        int[] counts = new int[13]; 

        //the count occurrences of each total
        foreach (int total in results)
        {
            counts[total]++;
        }

        //displays the actual histogram
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            //calculating the percentage, not just the number of rolls
            int percentage = counts[iCount] * 100 / results.Length;
            //determines how many asterisks to put based on the percentage
            Console.WriteLine($"{iCount}: {new string('*', percentage)}");
        }
    }
}