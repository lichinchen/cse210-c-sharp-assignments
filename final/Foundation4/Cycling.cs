public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) 
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed * GetMinutes() / 60; // Distance in miles
    }

    public override double Speed()
    {
        return _speed; // Speed is directly provided
    }

    public override double Pace()
    {
        return 60 / _speed; // Pace in minutes per mile
    }
}
