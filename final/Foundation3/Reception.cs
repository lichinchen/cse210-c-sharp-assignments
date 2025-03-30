public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void GetReceptionsFullDetails()
    {
        Console.WriteLine(GetFullDetails());
        //GetFullDetails();
        Console.WriteLine($"RSVP Email: {_rsvpEmail}");
    }
}
