using System;     // Basic functionality
using System.Net; // Network functions

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");     // Ask for magic number
        //int magicNumber = int.Parse(Console.ReadLine()); // Read magic number
        Random randomGenerator = new Random();             // Create random number
        int magicNumber = randomGenerator.Next(1, 101);    // Generate random number (1 to 100)
        //Console.WriteLine(magicNumber);                    // Display the random number(test)

        int guessNumber;                                 // Declare guessNumber variable
        do
        {
            Console.Write("What is your guess(1-100)? ");       // Ask for guess number
            guessNumber = int.Parse(Console.ReadLine()); // Read guess number
    
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");             // Guess higher
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");              // Guess lower
            }
            else
            {
                Console.WriteLine("You guess it!");      // Correct guess
            }
        } while (magicNumber != guessNumber);            // Loop until guess correct
        
    }
}