using System;
class Program
{
    static void Main()
    {
        //Create array to hold rolls
        int[] rolls = new int[11];

        //Track # of rolls made
        int numRolls = 0;

        //Ask the User how many times to roll the dice
        Console.Write("How many dice rolls would you like to simulate? ");
        int numRollsRequested = int.Parse(Console.ReadLine());

        //Random number generator 
        Random rand = new Random();

        //Roll in the dice
        while (numRolls < numRollsRequested)
        {
            // Die #1
            int roll1 = rand.Next(1, 7);
            // Die #2
            int roll2 = rand.Next(1, 7);
            
            //Calculate total of each roll
            int total = roll1 + roll2;

            //adjust role total
            rolls[total - 2]++;
            //increment roll count
            numRolls++;
        }

        //Written text for assignement
        Console.WriteLine("Histogram of rolls:");
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each * represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls: " + numRolls);

        //for loop to create historagm that displays the number of times each number was rolled.
        for (int digit = 2; digit <= 12; digit++)
        {
            Console.Write("{0,3}: ", digit);

            //Calc # of * for each column of histogram
            int numStars = (int)Math.Round(100.0 * rolls[digit - 2] / numRolls);
            for (int star = 0; star < numStars; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!") ;
    }
}
