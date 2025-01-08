using System;     // Basic functionality
using System.Net; // Network functions

class Program
{
    static void Main(string[] args)
    {
        string askReplay = "y";                                // Initialize replay option
         while (askReplay == "y")                              // Loop for replaying the game
        {
            //Console.Write("What is the magic number? ");     // Ask for magic number
            //int magicNumber = int.Parse(Console.ReadLine()); // Read magic number
            Random randomGenerator = new Random();             // Create random number
            int magicNumber = randomGenerator.Next(1, 101);    // Generate random number (1 to 100)
            //Console.WriteLine(magicNumber);                  // Display the random number(test)
       
            int guessNumber;                                   // Declare guessNumber variable
            int trackGuess = 0;                                // Initiallize the number of guesses
            do
            {
                Console.Write("What is your guess(1-100)? ");  // Ask for guess number
                guessNumber = int.Parse(Console.ReadLine());   // Read guess number
        
                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");               // Guess higher
                    trackGuess += 1;
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");                // Guess lower
                    trackGuess += 1;
                }
                else
                {
                    Console.WriteLine("You guess it!");        // Correct guess
                    trackGuess += 1;
                }
            } while (magicNumber != guessNumber);              // Loop until guess correct
    
            Console.WriteLine($"You guessed {trackGuess} times!"); // Display total guesses
            Console. Write("Would you like to play again?(y/n) "); // Ask if user wants to replay
            askReplay = Console.ReadLine();                        // Read replay option
            
            
        }
        Console.WriteLine("We hope you enjoyed the game!");        // End game message
        
    }
}