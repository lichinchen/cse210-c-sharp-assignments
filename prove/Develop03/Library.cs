using System;                      // Import System
using System.Collections.Generic;  // Import collections

// Library class to manage scripture
public static class Library
{
    // Method to return a single verse
    public static Scripture GetSingleVerse()
    {
        Reference reference = new Reference("John", 3, 16);  // Reference for John 3:16
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";  // Verse text
        Scripture scripture = new Scripture(reference, scriptureText);  // Create Scripture object
        return scripture;  // Return Scripture
        
    }

    // Method to return multiple verses
    public static Scripture GetMultipleVerses()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);  // Reference for Proverbs 3:5-6
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.\n" +
                               "In all thy ways acknowledge him and he shall direct thy paths.";  // Verse text
        Scripture scripture = new Scripture(reference, scriptureText);  // Create Scripture object
        return scripture;  // Return Scripture
    }
}
