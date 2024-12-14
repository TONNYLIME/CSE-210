using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void setAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget()
    {
        return _target;

    }
    public void setTarget(int target)
    {
        _target = target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void setBonus(int bonus)
    {
        _bonus = bonus;
    }
    public CheckListGoal( ) 
    {
        
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
   {
        return _isComplete;
   }
    public override string GetDetailsString()
    {
         return $"[ ] {_name}: {_description} (Accomplished {_amountCompleted}/{_target} times)";
    }
    public override string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_target:yyyy-MM-dd}|{_points}|{_bonus}";
    }

}
