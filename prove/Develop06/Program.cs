using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        
        

        SimpleGoal simpleGoal = new SimpleGoal(true);
        
        simpleGoal.setName("Simple Goal");
        
        Console.WriteLine($"Is simple goal complete? {simpleGoal.IsComplete()}");

        CheckListGoal checklistGoal = new CheckListGoal();
        //checklistGoal.AmountCompleted = 3; // Let's assume it's been accomplished 3 times.
        Console.WriteLine(checklistGoal.GetDetailsString());
    }
}