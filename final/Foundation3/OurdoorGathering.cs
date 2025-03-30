public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public void GetOutdoorFullDetails()
    {
        Console.WriteLine(GetFullDetails());
        //GetFullDetails();
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");
    }
}
