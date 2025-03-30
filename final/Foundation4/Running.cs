public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) 
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        //return (_distance / _minutes) * 60; // Speed in miles per hour
        double distancePerMinute = _distance / GetMinutes(); 
        double speed = distancePerMinute * 60; 
        return speed; 
    }

    public override double Pace()
    {
        return 60 / (_distance / GetMinutes()); // Pace in minutes per mile
    }
}
