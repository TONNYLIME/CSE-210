using System;

public class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _numberOfLaps = laps;
    }
    // in kilometers
    public override double GetDistance()
    {
        return (_numberOfLaps* 50 )/ 1000.0;
    }  
    // kph
    public override double GetSpeed()  
    {
        return (GetDistance() / _length) * 60;
    }
    // minutes per km
    public override double GetPace()   
    {
        return _length / GetDistance();
    }
}