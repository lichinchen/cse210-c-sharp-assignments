using System;                     // Basic functionality
using System.Collections.Generic; // For List
using System.IO;                  // File handling


public class Journal  // The Journal class adds, displays, saves, and loads journal entries.
{
    private List<Entry> entries = new List<Entry>();  // List to store journal entries
    private int entryCounter = 1;                     // Entry counter to keep track of entry numbers

    public Journal()  // Default constructor
    {
        //It tells the program that this journal is empty at the beginning and has no content. 
        // You can fill it with entries when you start writing.
    }


    public void AddEntry(string date, string prompt, string diaryText)  // Add a new journal entry to the list.
    {
        foreach ( Entry entry in entries)                               // Iterate through existing entries
        {
            if (entry._entryDate == date && entry._entryPrompt == prompt && entry._entryDiaryText == diaryText)  // 2. Check if the entry already exists
            {
                Console.WriteLine("This entry already exists.");        // If entry exists, print it
                return;                                                 // Exit method 
            }
        }
        Entry newEntry = new Entry();            // Create a new Entry object.
                                              
        newEntry._entryDate = date;              // Set the provided date, prompt, and diary text to the new object.
        newEntry._entryPrompt = prompt;       
        newEntry._entryDiaryText = diaryText; 

        newEntry._entryNumber = entryCounter++;  // Assign a number and increment for the next entry

        entries.Add(newEntry);                   // Add the new entry to the entries list.
        
    }


    public void DeleteEntry(int entryNumber)    // Method to delete an entry by entry number
    {
        Entry entryRemove = null;               // Declare a variable to store the entry to remove

        foreach (Entry entry in entries)        // Iterate through all entries
        {
            if (entry._entryNumber == entryNumber) // Find the entry by number
            {                                   
                entryRemove = entry;            // Assign the entry to remove
                break;                          // Exit loop
            }
        }
        
        if (entryRemove != null)                // Check if an entry was found
        {
            entries.Remove(entryRemove);        // Remove the entry from the list
            Console.WriteLine($"Entry {entryNumber} has been deleted successfully."); // Print success message

            RenumberEntry();                    // Renumber entries after deletion
            entryCounter = entries.Count + 1;   // Update the entry counter
        }

        else
        {
            Console.WriteLine($"Entry {entryNumber} not found."); // Print error if entry is not found
        }
    }


    public void RenumberEntry()                 // Method to renumber entries after deletion
    {
        for (int i = 0; i <entries.Count; i++)  // Iterate through the list
        {
            entries[i]._entryNumber = i + 1;    // Set the entry number
        }
    }


    public void DisplayEntries()                // Display all the journal entries.
    {
        foreach (Entry entry in entries)       // Iterate through each entry in the entries list.
        {
            entry.DisplayEntry();              // Call the entry's DisplayEntry() method 
            Console.WriteLine("-------------------------------------\n"); // Print a separator line for readability.
        }
    }


    public void SaveFileOverwrite(string filename)                    // Method to save all entries by overwriting the file
    {
        RenumberEntry();
        using (StreamWriter writer = new StreamWriter(filename))      // Create a StreamWriter to overwrite the file
        
        {
            foreach (Entry entry in entries)                          // Iterate through entries
            {
                writer.WriteLine($"{entry._entryNumber} | {entry._entryDate} | {entry._entryPrompt} | {entry._entryDiaryText}");  // 2. Write each entry to the file
            }
        }
        Console.WriteLine("File overwrite and saved successfully!");  // Show a success message when saved.
    }


    public void SaveFileAppend(string filename)                       // Method to append entries to a file
    {
        int maxNumber = 0;                                            // Variable to store the maximum entry number
       
        if (File.Exists(filename))                                    // Check if the file exists
        {
            string[] lines = File.ReadAllLines(filename);             // Read all lines from the file
           
            foreach (string line in lines)                            // Iterate through each  line in the file
            {
                string[] parts = line.Split('|');                     // Split the line by "|"
                if (parts.Length == 4)                                // 4 parts: number, date, prompt, diary text
                {
                    string entryNumber = parts[0].Trim();             // Extract and trim the entry number
                    int num;
                    try
                    {
                        num = int.Parse(entryNumber);                 // Parse the entry number
                        if (num > maxNumber)                          // If the current number is greater than maxNumber
                        {
                            maxNumber = num;                          // Update maxNumber
                        }
                    }
                    catch (FormatException)                           // Catch parsing errors
                    {
                        Console.WriteLine($"Invalid number format: {entryNumber}"); // Print error message
                    }
                }
            }
        }
        entryCounter = maxNumber + 1;                                // Set the entry counter to the next available number
        if (entries.Count > 0)                                       // If there are entries in the list
        {
            Entry lastEntry = entries[entries.Count - 1];            // Get the last entry
            lastEntry._entryNumber = entryCounter;                   // Set the new entry number
            entryCounter = entryCounter + 1;
           
            using (StreamWriter writer = File.AppendText(filename))  // Open the file to append
            {
                    writer.WriteLine($"{lastEntry._entryNumber} | {lastEntry._entryDate} | {lastEntry._entryPrompt} | {lastEntry._entryDiaryText}");                  
            }
       
            Console.WriteLine("File appended successfully!");        // Print success message
        }
        else
        {
            Console.WriteLine("No lastest entry to save.");          // Print message if no entries to save
        }
    }


    public void LoadFile(string filename)                   // Load journal entries from a file.
    {
        if (File.Exists(filename))                          // Check if the file exists.
        {
            string[] lines = File.ReadAllLines(filename);   // Read all lines from the file.
            int maxNumber = 0;                              // Track the highest entry number.
            foreach (string line in lines)                  // Loop through each line.
            {                              
                string[] parts = line.Split('|');           // Split line into 4 parts and using "|".
                if (parts.Length == 4)                      // make sure 4 parts
                {
                    Entry entry  = new Entry();             // Create a new entry.
                    entry._entryNumber = int.Parse(parts[0].Trim());  // Set entry number
                    entry._entryDate = parts[1].Trim();     // Set date
                    entry._entryPrompt = parts[2].Trim();   // Set prompt
                    entry._entryDiaryText = parts[3].Trim();// Set diary text

                    bool entryExists = false;               // Assume the entry doesn't exist.

                    
                    foreach (var existingEntry in entries)  // Check if the entry already exists.
                    {
                        // Check if the entry number matches
                        if (existingEntry._entryNumber == entry._entryNumber &&      // Match entry number
                            existingEntry._entryDate == entry._entryDate &&          // Match date
                            existingEntry._entryPrompt == entry._entryPrompt &&      // Match prompt
                            existingEntry._entryDiaryText == entry._entryDiaryText)  // Match text
                        {
                            entryExists = true;                                      // Set to true if found
                            break;                                                   // Stop checking
                        }
                    }
                    
                    
                    if (entryExists)                                                 // If entry is found, tell user
                    {
                        Console.WriteLine("Entry already loaded.");
                    }
                    else                                                             // Add the entry to the list
                    {
                        entries.Add(entry);  

                    }
                                       
                    if (entry._entryNumber > maxNumber)                              
                    {
                        maxNumber = entry._entryNumber;                              // Update maxNumber if a larger entry number is found
                    }
                }
            } 
            entryCounter = maxNumber + 1;                   // Set next entry number
            Console.WriteLine("\nLoaded journal entries..."); // Notify user
            foreach (Entry entry in entries)                // Display all loaded entries
            {
                Console.WriteLine($"{entry._entryNumber} | {entry._entryDate} | {entry._entryPrompt} | {entry._entryDiaryText}");
            }                                          
            Console.WriteLine("File loaded successful!");   // Display a success message if the file exists
        }
        else
        {
            Console.WriteLine("File not found.");           // Error message if the file doesn't exist.
        }
    }


    public void EditEntry(string choice)                      // Edit by date or entry number 
    {
        Entry entryToEdit = null;                           // Store the entry to edit
        
        if (choice == "1")                                  // Search by date  
        {
            Console.Write("Enter the date of the journal entry you want to edit (yyyy-MM-dd): ");  // Ask the date to edit
            string dateToEdit = Console.ReadLine();          // Read input

            foreach (Entry entry in entries)                 // Loop through entries 
            {
                if (entry._entryDate == dateToEdit)          // Match date  
                {
                    entryToEdit = entry;                     // Store entry for editing 
                    break;
                }
            } 
        }
        else if (choice == "2")                             // Search by entry number  
        {  
            Console.Write("Enter the entry number: ");      // Ask for number
            string numberInput = Console.ReadLine();        // Input as a string 
            int entryNumber = int.Parse(numberInput);       // Convert to an integer 
            foreach (Entry entry in entries)                // Loop through entries
            {
                if (entry._entryNumber == entryNumber)      // Match number
                {
                    entryToEdit = entry;                    // Store entry for editing
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");          // Error message 
            return;
        }
        if (entryToEdit == null)                           // If entry not found
        {
            Console.WriteLine("Entry not found.");
            return;
        }
        // Display found entry
        Console.WriteLine($"Found entry {entryToEdit._entryNumber}: {entryToEdit._entryDate}");
        Console.WriteLine($"Prompt: {entryToEdit._entryPrompt}");
        Console.WriteLine($"Diary Text: {entryToEdit._entryDiaryText}");
        
        // Edit prompt
        Console.Write("\nEdit the prompt (or press Enter to keep current): ");   // Ask for new prompt
        string editPrompt = Console.ReadLine();                                  // Read user input
        if (editPrompt == null || editPrompt == "")                              // If no input, keep the current prompt  
            editPrompt = entryToEdit._entryPrompt;                     
        
        // Edit diary text
        Console.Write("Enter new diary text (or press Enter to keep current): "); // Ask for new text
        string editDiaryText = Console.ReadLine();                                // Read user input
        if (editDiaryText == null || editDiaryText == "")                         // If no input, keep the current diary text
            editDiaryText = entryToEdit._entryDiaryText;  
        
        entryToEdit._entryPrompt = editPrompt;               // Update prompt
        entryToEdit._entryDiaryText = editDiaryText;         // Update diary text 
        Console.WriteLine("\nEntry updated successfully.");  // Print success message
        
    }    

    
}