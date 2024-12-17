using System;

public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    // miles per hour
    public override double GetSpeed()
      {
        return _distance/ _length * 60;
      } 

    // minutes per mile
    public override double GetPace() 
    {
        return _length / _distance;
    }
}
