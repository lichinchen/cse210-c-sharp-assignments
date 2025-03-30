using System;  // Import system namespace

// Inherits from Event
// Stores the weather forecast
// Constructor
// Calls GetFullDetails() from Event
// Prints the weather forecast

// Inherit from Event class
public class OutdoorGathering : Event
{
    private string _weatherForecast;  // Store the weather forecast

    // Constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string type, string weatherForecast)
        : base(title, description, date, time, address, type)  // Call base class constructor
    {
        _weatherForecast = weatherForecast;  // Set the weather forecast value
    }

    // Method to get outdoor event details
    public void GetOutdoorFullDetails()
    {
        Console.WriteLine(GetFullDetails());                         // Call the base class method to get full event details
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");  // Print weather forecast
    }
}
