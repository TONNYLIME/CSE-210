using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _length;
    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get the summary of the activity
    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_length} min) - " +
               $"Distance {distance:0.0} {(this is Running || this is Cycling ? "miles" : "km")}, " +
               $"Speed {speed:0.0} {(this is Running || this is Cycling ? "mph" : "kph")}, " +
               $"Pace: {pace:0.0} min per {(this is Running || this is Cycling ? "mile" : "km")}";
    }
}