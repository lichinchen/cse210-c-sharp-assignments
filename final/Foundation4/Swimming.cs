using System;  // Import system namespace

// Inherits from Activity
// Stores Laps
// Constructor
// Calculates Distance
// Calculates Speed
// Calculates Pace


// Swimming class inherits from Activity
public class Swimming : Activity
{
    private int _laps;  // Stores the laps

    // Constructor
    public Swimming(string date, int minutes, int laps) 
        : base(date, minutes)  // Call the base class constructor
    {
        _laps = laps;  // Set the number of laps
    }

    // Override Distance method
    public override double Distance()
    {
        return _laps * 50 / 1000.0 * 0.62;  // Convert laps to miles
    }

    // Override Speed method
    public override double Speed()
    {
        double distancePerMinute = Distance() / GetMinutes();  // Calculate distance per minute
        double speed = distancePerMinute * 60;                 // Convert to miles per hour
        return speed;                                          // Return the speed
    }

    // Override Pace method
    public override double Pace()
    {
        return 60 / Speed();  // Pace in minutes per mile
    }
}
