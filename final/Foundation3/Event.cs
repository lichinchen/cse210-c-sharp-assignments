using System;  // Import system namespace

// Tasks of the Event Class
// Store event details
// Constructor – It sets up the event with the given details.
// Show standard event details 
// Show full event details 
// Show a short event details

// Defines an Event class
public class Event
{
    // Stores event title, description, date, time, address
    private string _title;  
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // Constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        // Assigns title, description, date, time, address value
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Returns standard event details
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date} { _time}\nAddress: {_address.GetAddress()}";
    }

    // Returns full event details
    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {GetType().Name}";
    }

    // Returns a short event details
    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nName: {_title}\nDate: {_date}";
    }
}
