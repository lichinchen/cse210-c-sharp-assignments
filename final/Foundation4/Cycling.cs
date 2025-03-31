using System;  // Import system namespace

// Inherits from Activity
// Stores Speed
// Constructor
// Calculates Distance
// Returns Speed
// Calculates Pace

// Cycling class inherits from Activity
public class Cycling : Activity
{
    private double _speed;  // Stores the speed

    // Constructor
    public Cycling(string date, int minutes, double speed) 
        : base(date, minutes)  // Call the base class constructor
    {
        _speed = speed;  // Set the speed
    }

    // Override Distance method
    public override double Distance()
    {
        return _speed * GetMinutes() / 60;   // Distance in miles (speed * time in hours)
    }

    // Override Speed method
    public override double Speed()
    {
        return _speed;  // Return the speed value
    }
    
    // Override Pace method
    public override double Pace()
    {
        return 60 / _speed;   // Pace in minutes per mile
    }
}
