using System;  // Import system namespace

// Inherits from Activity
// Stores Distance
// Constructor
// Returns Distance
// Calculates Speed
// Calculates Pace

// Running class inherits from Activity
public class Running : Activity
{
    private double _distance;  // Stores the distance 

    // Constructor
    public Running(string date, int minutes, double distance) 
        : base(date, minutes)   // Call the base class constructor
    {
        _distance = distance;  // Set the distance
    }

    // Override Distance method
    // Returns the distance directly
    public override double Distance()
    {
        return _distance;  // Return the distance
    }

    // Override Speed method
    // Calculates speed
    public override double Speed()
    {
        double distancePerMinute = _distance / GetMinutes();   // Calculate distance per minute
        double speed = distancePerMinute * 60;                 // Convert to miles per hour
        return speed;                                          // Return the speed
    }

    // Override Pace method
    // Calculates pace
    public override double Pace()
    {
        return 60 / (_distance / GetMinutes());                // Pace in minutes per mile
    }
}
