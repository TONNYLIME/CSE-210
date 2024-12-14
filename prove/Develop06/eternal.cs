using System;

public  class EternalGoal : Goal
{
    public EternalGoal(string name,string description , string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"{_name} | {_description}|{_isComplete}-{_points}");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return _description;
    }

}