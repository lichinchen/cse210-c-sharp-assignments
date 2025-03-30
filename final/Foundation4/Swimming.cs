public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Convert laps to miles
    }

    public override double Speed()
    {
        double distancePerMinute = Distance() / GetMinutes(); 
        double speed = distancePerMinute * 60; 
        return speed;
    }

    public override double Pace()
    {
        return 60 / Speed(); // Pace in minutes per mile
    }
}
