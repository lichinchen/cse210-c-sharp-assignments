using System;  // Import system namespace

// Stores a collection of activities
// Add activities
// Calculate total exercise time
// Format total time
// Display activity summaries

public class ActivityManager
{
    // List of activities
    private List<Activity> _activities = new List<Activity>();  

    // Add activity to list
    public void AddActivity(Activity activity)                  
    {
        _activities.Add(activity);  
    }

    // Calculate total minutes
    public int TotalOfMinutes()                                
    {
        int total = 0;  
        foreach (var activity in _activities)  
            total += activity.GetMinutes();  
        return total;  
    }

    // Format total time as hours and minutes
    public string TimeFormatted()                               
    {
        int totalMinutes = TotalOfMinutes();  
        return $"{totalMinutes / 60} hours {totalMinutes % 60} minutes";  
    }

    // Display activity summaries
    public void DisplaySummaries()                               
    {
        foreach (var activity in _activities)  
        {
            if (activity.GetType().Name == "Running")  
                Console.ForegroundColor = ConsoleColor.DarkGreen;  
            else if (activity.GetType().Name == "Cycling")  
                Console.ForegroundColor = ConsoleColor.Cyan;  
            else if (activity.GetType().Name == "Swimming")  
                Console.ForegroundColor = ConsoleColor.DarkYellow;  

            // Print activity summary
            Console.WriteLine(activity.GetSummary());  

            // Reset color back to default
            Console.ResetColor();  
        }
    }
}
