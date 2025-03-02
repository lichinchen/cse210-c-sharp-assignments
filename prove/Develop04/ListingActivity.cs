using System;                          // Basic functions
using System.Collections.Generic;      // Collections
using System.Threading;                // Threading

// Inherits from Activity class
public class ListingActivity : Activity
{
    private int _maxItems;               // Maximum number of items the user can list

    // Constructor for ListingActivity class
    // Initializes the name, description, and duration from the base class (Activity)
    public ListingActivity(string name, string description, int duration, int maxItems)
        : base(name, description, duration)   // Initializes base class properties
    {
        _maxItems = maxItems;                 // Sets the maximum item count
    }

    // Get random prompt for listing activity
    public string GetRandomPrompt()
    {
        string[] listingPrompts =
        {
            "==> Who are people that you appreciate?",
            "==> What are personal strengths of yours?",
            "==> Who are people that you have helped this week?",
            "==> What makes you proud?",
            "==> What is your greatest achievement?"
        };

        Random random = new Random();                           // Create random object
        int randomIndex = random.Next(listingPrompts.Length);   // Get random index
        return listingPrompts[randomIndex];                     // Return random prompt
    }

    // Display listing prompt to user
    public void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine($"You can list up to {_maxItems} items. Feel free to take your time!\n");  // Remind user of the max items they can list
        string topic = GetRandomPrompt();                     // Get random topic
        Console.WriteLine(topic);                             // Display the topic
        for (int i = 10; i >= 0; i--)                         // Countdown from 10 to 1
        {
            Console.SetCursorPosition(0, Console.CursorTop);  // Position the cursor at the start 
            Console.Write($"You may begin in: {i} ");         // Print the countdown number
            Thread.Sleep(1000);                               // Wait for 1 second
        }

        Console.WriteLine();     
    }

    // Collect user responses for the listing activity
    public List<string> GetUserInput()
    {
        Console.WriteLine("\nLet's start your list!");
        Console.WriteLine("\nType 'done' when you're finished.");  
        Console.WriteLine("\nType your items and press Enter.");  
       

        List<string> userInput = new List<string>();  // 
        int remainingItems = _maxItems;               // Track remaining items to be entered

        for (int i = 0; i < _maxItems; i++)
        {
            Console.Write(">> ");                     // Display >> before each input
            string response = Console.ReadLine();
            if (response.ToLower() == "done")
            {
                break;
            }
            userInput.Add(response);                 // Add input to response list
            remainingItems--;                        // Decrease remaining item count
            Console.WriteLine($"\nYou have {remainingItems} more items to go. No rush!"); // Inform user of remaining items
        }
        return userInput;
    }

    // Run Listing Activity
    public void ExecuteListingActivity()
    {
        ExecuteStartActivity();                                     // Inherited method
        DisplayPrompt();                                            // Show the listing prompt
        List<string> userInput = GetUserInput();                    // Collect user responses
        Console.WriteLine($"\nYou listed {userInput.Count} items.");  // Display number of items listed
        ExecuteEndActivity();                                       // Inherited method
    }
}
