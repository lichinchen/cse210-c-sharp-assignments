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
            else
            {
            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            Console.ReadKey();
            }        
        }
        Console.WriteLine("\nGame over! Press Enter to exit.");  // Inform user the game is over
        Console.ReadLine();                                      // Wait for user to press Enter to close
    }

    // Method for displaying scripture and hiding words
    static void RunGame(Scripture scripture)
    {
        // Reset all words to visible 
        scripture.ResetAllWords();
        
        // Game loop - keeps hiding words until all are hidden or user quits
        while (true)
        {
            // Clear the console for a fresh display
            Console.Clear();

            // Hide random words from the scripture
            scripture.HideRandomWords(); 

            // Display the current scripture text
            Console.WriteLine();
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            // Read user input
            string input = Console.ReadLine();
            // If the user types "quit", break the loop and exit the game
            if (input.ToLower() == "quit")
                break;

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



// The program exceeds the core requirements:
// 1. My HideRandomWords() method makes sure only visible words are selected randomly for hiding.
// 2. Number of visible words before/after hiding
// 3. Create a scripture library and random display the single or mutilple verses.
// 4. Create a menu for the user to select an option: 1. single verse 2. multiple verses 3. quit