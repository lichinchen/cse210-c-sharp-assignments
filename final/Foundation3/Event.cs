using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date} { _time}\nAddress: {_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {GetType().Name}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nName: {_title}\nDate: {_date}";
    }
}
