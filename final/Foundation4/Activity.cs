using System;  // Import system namespace

// Stores Activity Information: _date, _minutes 
// Constructor
// Get Minutes
// Abstract Methods: Distance(), Speed(), and Pace()
// Get Summary

public abstract class Activity
{
    private string _date;  // Stores the date
    private int _minutes;  // Stores the minutes

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;        // Set the date
        _minutes = minutes;  // Set the minutes
    }

    // Method to get the minutes
    public int GetMinutes()
    {
        return _minutes;
    }

     // Abstract for calculating distance
    public abstract double Distance();

    // Abstract for calculating speed
    public abstract double Speed();

    // Abstract for calculating pace
    public abstract double Pace();

    // Get a summary of the activity
    public string GetSummary()
    {                                                             // GetType().Name--Get the object's type name
        return $"{_date} {GetType().Name} ({_minutes} min)\n" +   // Return the date, activity type, and minutes 
               $"- Distance: {Distance():F2} miles\n" +           // Format distance with 2 decimal 
               $"- Speed: {Speed():F2} mph\n" +                   // Format speed with 2 decimal 
               $"- Pace: {Pace():F2} min/mile\n";                 // Format pace with 2 decimal 
    } 
}
