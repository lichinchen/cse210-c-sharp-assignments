using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public string GetSummary()
    {
        //return $"{_date} {GetType().Name} ({_minutes} min): Distance {Distance()}, Speed {Speed()}, Pace {Pace()}";
        return $"{_date} {GetType().Name} ({_minutes} min)\n" +
               $"- Distance: {Distance():F2} miles\n" +
               $"- Speed: {Speed():F2} mph\n" +
               $"- Pace: {Pace():F2} min/mile\n";
    }
}
