using System;

public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
     // miles
    public override double GetDistance() 
    {
        return _speed* _length / 60;
    } 
    // miles per hour
    public override double GetSpeed()
    {
        return _speed;
    }
    // minutes per mile
    public override double GetPace()  
    {
        return 60 / _speed;
    }
}