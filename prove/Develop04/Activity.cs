using System;                         // Import System
using System.Threading;               // Threading for time delays
using System.Collections.Generic;     // for List

public class Activity                 // Define Activity class
{
    private string _name;             // Activity name
    private string _description;      // Activity description
    private int _duration;            // Duration in seconds
    
    // Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;                                           // Set the activity name
        _description = description;                             // Set the activity description
        _duration = duration;                                   // Set the activity duration
    }

    
    public void SetName(string name)
    {
        _name = name;               // Set the name to a new value
    }

    
    public string GetName()
    {
        return _name;               // Return the current name
    }

    public void SetDescription(string description)
    {
        _description = description;  // Set the description to a new value
    }

    public string GetDescription()
    {
        return _description;         // Return the current description
    }

    
    public void SetDuration(int duration)
    {
        _duration = duration;        // Set the duration to a new value        
    }

    public int GetDuration()
    {
        return _duration;            // Return the current duration
    }


    // Display start message
    protected void DisplayStartMessage()
    {
        string startMessage = $"Let's get started...\n\nWelcome to the {_name} Activity \n\n{_description}";  // Create the start message
        Console.WriteLine($"\n{startMessage}");                                   // Display start message
        Console.WriteLine();                                                      // Print a blank line
    }
    
    protected void InputDuration()
    {
        while (true)  // Keep asking until a valid choice
        {
            Console.WriteLine("\nChoose a duration for your session:");
            Console.WriteLine("1. 20 seconds");
            Console.WriteLine("2. 30 seconds");
            Console.WriteLine("3. 60 seconds");
            Console.WriteLine("4. 120 seconds");
            Console.WriteLine("5. Set your own duration");
    
            // Get user input for choice
            string input = Console.ReadLine();
    
            if (input == "1")        // 20 seconds
            {
                SetDuration(20);
                break;               // Exit the loop
            }
            else if (input == "2")   // 30 seconds
            {
                SetDuration(30);  
                break;
            }
            else if (input == "3")    // 60 seconds
            {
                SetDuration(60);
                break;
            }
            else if (input == "4")    // 120 seconds
            {
                SetDuration(120);
                break;
            }
            else if (input == "5")    // Set your own duration
            {
                while (true)          // Keep asking until a valid duration
                {
                    Console.Write("\nEnter the time for your session (in seconds): ");
                    int userDuration = int.Parse(Console.ReadLine());   // Convert to integer
                    
                    if (userDuration >= 20)           // Validate duration
                    {
                        SetDuration(userDuration);    // Set custom duration
                        break;                        // Exit inner loop
                    }
                    else
                    {
                        Console.WriteLine("The minimum session duration is 20 seconds. Please enter again.");  // Breath in + out + preapare = 7+7+5=19 seconds
                    }
                }
                break;                                // Exit outer loop
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
        }
    }



    // Display end message
    protected void DisplayEndMessage()
    {
        string endMessage = "Awesome, you did it!";                               // Create the end message
        
        Console.WriteLine();
        Console.WriteLine($"\n{endMessage}");                                     // Display end message
        Console.WriteLine($"\nYou completed {_name} for {_duration} seconds!");   // Show duration
        DisplayEndAnimation();                                                    // Show animation for 5 seconds
        Console.WriteLine();
    }

    public void DisplayEndAnimation()
    {
        List<string> endAnimationStrings = new List<string>
        {
            "|", "/", "--", "\\", "|",               // Example end animation symbols
        };
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);  // Animation time for the end 
    
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string s = endAnimationStrings[i];
             
            Thread.Sleep(1000);                              // Wait for 1 second
            Console.Write("\b \b");                          // Remove previous animation
            
            Console.SetCursorPosition(0, Console.CursorTop); // Position the cursor at the start
            Console.Write(s);                                // Display current animation symbol
            
            i = (i + 1) % endAnimationStrings.Count;         // Add 1 to i.
                                                             // Use % to keep i within the list range.
                                                             // When i reaches the end, it resets to 0
        }

        Console.Write("\b \b");                              // Clear the last animation character
        Console.Write("  ");                                 // Overwrite the last symbol with spaces
        Console.SetCursorPosition(0, Console.CursorTop);     // Reset cursor position

        Console.WriteLine("\nWell done!");
    }

    protected void DisplayAnimation(int duration)
    {
        List<string> animationStrings = new List<string>
        {
            ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", "..........",
        };
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);   // Set animation end time

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
        
            Console.Write("\b \b");                          // Remove previous animation
        
            Console.SetCursorPosition(0, Console.CursorTop); // Position the cursor at the start
            Console.Write(s);                                // Display animation symbol
            Console.Write(" " + remainingSeconds);           // Display remaining time
            
            i = (i + 1) % animationStrings.Count;            // Add 1 to i.
                                                             // Use % to keep i within the list range.
                                                             // When i reaches the end, it resets to 0
            Thread.Sleep(1000);                              // Wait for 1 second
        }
        Console.Write("\b \b");                              // Clear the last displayed number
        Console.WriteLine();                                 // Newline after the animation
        Console.Write("   ");                                // Overwrite the last symbol with spaces
    }

    // Run activity
    
    public void ExecuteStartActivity()
    {
        DisplayStartMessage();           // Start message
        InputDuration();                 // The user inputs the time
    }

    public void ExecuteEndActivity()
    {
        DisplayEndMessage();             // End message  
    }   
}
