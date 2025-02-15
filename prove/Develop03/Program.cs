using System;                      // Import System
using System.Collections.Generic;  // Import collections

class Program
{
    static void Main()
    {
        // Game loop - keeps displaying the options until the user chooses to quit
        while (true)
        {
            // Display options
            Console.Clear();                           // Clear console screen
            Console.WriteLine("Select an option:");    // Display options menu
            Console.WriteLine("1. Single Verse");
            Console.WriteLine("2. Multiple Verses");
            Console.WriteLine("3. Quit");

            Console.Write("\nYour option:");           // Prompt for user input
            
            string input = Console.ReadLine();         // Get the user input

            if (input == "1")
            {
                // Get single verse from library
                Scripture scripture = Library.GetSingleVerse();
                RunGame(scripture);
            }
            else if (input == "2")
            {
                // Get multiple verses from library
                Scripture scripture = Library.GetMultipleVerses();
                RunGame(scripture);
            }
            else if (input.ToLower() == "quit" || input == "3")
            {
                // Exit the program
                break;
            }
        }
        Console.WriteLine("\nGame over! Press Enter to exit.");  // Inform user the game is over
        Console.ReadLine();                                      // Wait for user to press Enter to close
    }

    // Method for displaying scripture and hiding words
    static void RunGame(Scripture scripture)
    {
        // Game loop - keeps hiding words until all are hidden or user quits
        while (true)
        {
            // Clear the console for a fresh display
            Console.Clear();

            // Display the current scripture text
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            // Read user input
            string input = Console.ReadLine();
            // If the user types "quit", break the loop and exit the game
            if (input.ToLower() == "quit")
                break;

            // Hide random words from the scripture
            scripture.HideRandomWords();

            // If all words are hidden, notify the user and end the game
            if (scripture.AllWordsHidden())                                       // Check if all words are hidden
            {
                
                Console.Clear();                                                  // Clear the screen
                Console.WriteLine("Wow! You did it! The words are all hidden!");  // Congratulate user
                Console.WriteLine("\nPress Enter to return to menu.");            // Prompt to return to menu
                Console.ReadKey();                                                // Wait for user to press Enter
                break;                                                            // Exit the game loop and return to the menu
            }
        }
    }
}
