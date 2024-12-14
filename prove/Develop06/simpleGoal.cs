using System;

public  class SimpleGoal : Goal
{
    public static new bool _isComplete;
     public bool GetIsComplete()
    {
        return _isComplete;

    }
    public  static void setIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }


    
    public SimpleGoal(bool isComplete)
    {
        _isComplete = isComplete;
    }
    // Record an event for the goal (mark it as completed or add points)
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{_name} is now complete!");
        }
        else
        {
            Console.WriteLine($"{_name} is already complete.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_isComplete}|{_points}";
    }
    
}