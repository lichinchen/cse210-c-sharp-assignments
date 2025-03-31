using System;                       // Import system namespace
using System.Collections.Generic;   // For the list

// Creates a List of Activities
// Creates Activity Objects
// Adds Activities to the List
// Loops Through Activities
// Prints Activity Summary

class Program
{
    static void Main()
    {
        // Create an empty list of Activity objects
        List<Activity> activities = new List<Activity>();

        Running running = new Running("2025-4-03", 120, 3);        // Create a Running object
        Cycling cycling = new Cycling("2025-4-04", 90, 15);        // Create a Cycling object
        Swimming swimming = new Swimming("2025-4-05", 60, 20);     // Create a Swimming object

        activities.Add(running);     // Add the Running to the list
        activities.Add(cycling);     // Add the Cycling to the list
        activities.Add(swimming);    // Add the Swimming to the list

        // Loop through each activity in the list
        foreach (Activity activity in activities)
        {
            // Print the summary of each activity
            Console.WriteLine(activity.GetSummary());
        }
    }
}
