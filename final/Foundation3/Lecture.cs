using System;  // Import system namespace

// Tasks of this class
// Inherits from the Event class.
// Defines private fields--speaker, capacity
// Constructor
// Calls GetFullDetails() from the base class.
// Display speaker and capacity.

// Lecture class inherits Event
public class Lecture : Event
{
    private string _speaker;  // Speaker's name
    private int _capacity;    // Event's capacity

    // Constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)  // Call base class constructor
    {
        _speaker = speaker;    // Set the speaker's name
        _capacity = capacity;  // Set the event's capacity
    }

    // Method to get full lecture details
    public void GetLectureFullDetails()
    {
        Console.WriteLine(GetFullDetails());          // Call the base class method to get full event details
        Console.WriteLine($"Speaker: {_speaker}");    // Display speaker
        Console.WriteLine($"Capacity: {_capacity}");  // Display capacity
    }
}
