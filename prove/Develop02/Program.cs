using System;                     // Basic functionality
using System.Collections.Generic; // For List
using System.IO;                  // File handling

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();         // Initialize a new journal object
        Prompt prompt = new Prompt();  
        
        while (true)  // Main program loop
        {
            // Display the journal header
            ConsoleColor headColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n<>:... J O U R N A L ...:<>");  
            Console.ForegroundColor = headColor;

            // Display menu options
            ConsoleColor lineColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = lineColor;
            Console.WriteLine("Hey! 😄 What's on your mind today?");
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Write a new journal");
            Console.WriteLine("2. Review journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Edit journal");
            Console.WriteLine("6. Delete journal");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("7. Exit");
            Console.ForegroundColor = originalColor;
            Console.Write("Choose an option: ");

            // Read user input
            string option = Console.ReadLine();

            // Write a new journal entry
            if (option == "1")
            {
                Console.WriteLine("Choose a journaling option:");
                Console.WriteLine("1. Prompt");
                Console.WriteLine("2. Free writing");
                Console.Write("Your choice: ");
                string writeOption = Console.ReadLine();

                // Option 1: Prompt
                if (writeOption == "1")
                {
                    // Get a random prompt
                    string promptText = prompt.PromptIndex(); 
                    Console.WriteLine("Today's prompt: " + promptText);
                    
                
                    // Get user's response
                    Console.Write("Your response?: ");
                    string response = Console.ReadLine();
    
                    // Get the current date
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
    
                    // Add entry to the journal
                    journal.AddEntry(date, promptText, response);
                    Console.WriteLine("\nJournal entry added successfully.");
                    Console.WriteLine("\nImpressive work! Small daily reflections lead to big changes!");
                }
                // Option 2: Free writing
                else if (writeOption == "2")
                {
                    Console.WriteLine("Share what's on your mind:");
                    string freeWrite = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string writeType = "Free Writing";
                    journal.AddEntry(date, writeType, freeWrite);
                    Console.WriteLine("\nJournal entry added successfully.");
                    Console.WriteLine("\nGreat job! Every small step forward makes a big difference!");
                }
                
            }

            // Display all journal entries
            else if (option == "2")
            {
                journal.DisplayEntries();
            }

            // Save journal to a file
            else if (option == "3")
            {
                Console.Write("What is the filename(with .txt): ");
                string filename = Console.ReadLine();

                Console.WriteLine("Do you want to overwrite (1) or append (2) to the file?");
                string saveOption = Console.ReadLine();

                // Save to file and overwrite
                if (saveOption == "1")
                {
                    journal.SaveFileOverwrite(filename);
                }

                // Save to file and append
                else if (saveOption == "2")
                {
                    journal.SaveFileAppend(filename);
                }

                // Save option canceled
                else
                {
                    Console.WriteLine("Save Canceled!");
                }
            }

            // Load journal entries from a file
            else if (option == "4")
            {
                Console.Write("What is the filename(With .txt): ");
                string filename = Console.ReadLine();
                journal.LoadFile(filename);
            }

            // Edit journal
            else if (option == "5")
            {
                // Choose edit method  
                Console.Write("Edit by (1) Date or (2) Entry Number? "); 
                string choice = Console.ReadLine();                       

                journal.EditEntry(choice);
            }

            
            // Delete journal
            else if (option == "6")
            {
                Console.Write("Enter the entry number to delete: ");
                string numberInput = Console.ReadLine();
            
                try
                {
                    int entryNumber = int.Parse(numberInput);
                    journal.DeleteEntry(entryNumber);
                    Console.WriteLine($"The entry number {entryNumber} has been deleted.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry number. Please enter a valid number.");
                }
            }


            // Exit the program
            else if (option == "7")
            {
                // Ask if the user wants to save before exiting
                Console.Write("Save before exit? (y/n): ");
                string saveAnswer = Console.ReadLine();
                if (saveAnswer == "y" || saveAnswer == "Y")
                {
                    Console.Write("What is the filename(with .txt): ");
                    string filename = Console.ReadLine();  

                    // Save option
                    Console.WriteLine("Overwrite (1) or Append (2) to the file?");
                    string saveOption = Console.ReadLine();
    
                    // Save to file and overwrite
                    if (saveOption == "1")
                    {
                        journal.SaveFileOverwrite(filename);
                    }

                    // Save to file and append
                    else if (saveOption == "2")
                    {
                        journal.SaveFileAppend(filename);
                    }
                }

                // Without saving and then exit
                else
                {
                    Console.WriteLine("Exiting without saving."); // Exit without saving
                }
                Console.WriteLine("Thank you! See you soon!\n");
                break;  // Exit the program
            }
        }
    }
}  

// My program exceeds the core requirements.
// 1. In option 1 of the main menu, I allow the user to have two methods to write journal: 1. Prompt 2. Free Writing
// 2. In option 3 of the main menu, I allow the user to have tow methods to save entry to file: 1. Overwrite 2. Append
// 3. In option 4 of the main menu, I added some code to check if the entry already exists and it had been loaded to avoid repeated loading.
// 4. In option 5 of the main menu, I added a new editing function. It can be edited by 1. date 2. entry number and then saved(overwrite), and the change can be seen.
// 5. In option 6 of the main menu, I added a new deleting function. It can be deleted by searching entry number and then saved, and the change can be seen.
// 6. In option 7 of the main menu, I allow the user to think again about whether to save the file. 1. Save (1.overwrite 2. append) 2.Exit
// 7. I added colors to the main menu.
// 8. Each entry stored in the file is numbered. Even after deleting and then save(overwrite) it, you can still see the sequential numbers.
