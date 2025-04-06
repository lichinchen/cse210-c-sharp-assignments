using System;                       // Import system namespace
using System.Collections.Generic;   // For the list

// Creates Activity Objects
// Adds Activities to the List
// Call DisplaySummaries()
// Output total time

class Program
{
    static void Main()
    {
        // Creates a new instance of ActivityManager
        ActivityManager activities = new ActivityManager();         

        // Create a Running, Cycling, Swimming object
        Running running = new Running("2025-4-03", 120, 3);        
        Cycling cycling = new Cycling("2025-4-04", 90, 15);        
        Swimming swimming = new Swimming("2025-4-05", 60, 20);     

         // Adds the running, cycling, swimming activity to the ActivityManager's list
        activities.AddActivity(running);
        activities.AddActivity(cycling);
        activities.AddActivity(swimming);

        // Displays summaries of all activities in the list
        activities.DisplaySummaries();

        // Prints total exercise time in minutes
        Console.WriteLine($"You've exercised for a total of {activities.TotalOfMinutes()} minutes.\n");

        // Prints total time in hours and minutes
        Console.WriteLine($"Total Time: {activities.TimeFormatted()}\n");

    }
}
