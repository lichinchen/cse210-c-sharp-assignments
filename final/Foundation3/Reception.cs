using System;  // Import system namespace

// Inherits from the Event class.
// Stores an RSVP email address. 
// Constructor
// Display full event details, including the RSVP email


// Inherits from Event class
public class Reception : Event
{
    private string _email;  // Stores the email

    // Constructor
    public Reception(string title, string description, string date, string time, Address address, string type, string Email)
        : base(title, description, date, time, address, type)   // Calls base class constructor
    {
        _email = Email;  // Sets the email
    }

    // Method to display full reception details
    public void GetReceptionsFullDetails()
    {
        Console.WriteLine(GetFullDetails());         // Call the base class method to get full event details
        Console.WriteLine($"RSVP Email: {_email}");  // Displays RSVP email
    }
}
