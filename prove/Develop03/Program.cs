using System;                      // Import System
using System.Collections.Generic;  // Import collections

class Program
{
    static void Main()
    {
        // Initialize a reference for a scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Create a scripture object with reference and text
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Game loop
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
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden! Well done!");
                break;
            }
        }
    }
}
