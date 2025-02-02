using System;  // Basic functionality

public class Entry
{
    public string _entryDate = "";       // Stores the date of the entry
    public string _entryPrompt = "";     // Stores the prompt for the entry
    public string _entryDiaryText = "";  // Stores the diary text
    public int _entryNumber = 0;         // Stores the entry number

    public Entry()
    {
       // Default constructor
    }
    public void DisplayEntry()
    {
        // Displays the entry details in the console
        Console.WriteLine($"Date: {_entryDate}");
        Console.WriteLine($"Prompt: {_entryPrompt}");
        Console.WriteLine($"Diary: {_entryDiaryText}");
    }

}