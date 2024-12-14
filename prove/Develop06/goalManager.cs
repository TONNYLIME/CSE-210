using System.IO;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
     { 

     }

    public void Start()
    {
        bool isRunning = true;
        while (isRunning)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nGoal Manager Menu:");
        Console.WriteLine("1. Display Player Info");
        Console.WriteLine("2. List Goal Names");
        Console.WriteLine("3. List Goal Details");
        Console.WriteLine("4. Create Goal");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Save Goals");
        Console.WriteLine("7. Load Goals");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nGoal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal._name);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        foreach (var goal in _goals)
        {
            string completionStatus = goal._isComplete ? "[X]" : "[ ]";
            Console.WriteLine($"{completionStatus} {goal._name} - {goal._name}");
        }
    }

    public void CreateGoal()
    {
        bool isRunning = true;
        while (isRunning)
        {
            GoalManagerMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SimpleGoal();
                    break;
                case "2":
                    EternalGoal();
                    break;
                case "3":
                    CheckListGoal();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private void GoalManagerMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");
    }

    public void SimpleGoal()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        //Goal simpleGoal = new Goal(name, description, false, points);
        //simpleGoal.Add(simpleGoal);
        Console.WriteLine("Simple goal created successfully!");
    }

    public void EternalGoal()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

       // Goal eternalGoal = new Goal("Temple", "description", false, 10);
       // _goals.Add(eternalGoal);
        Console.WriteLine("Eternal goal created successfully!");
    }

    public void CheckListGoal()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

       // Goal checkListGoal = new Goal(name, description, false, points);
       // _goals.Add(checkListGoal);
        Console.WriteLine("Checklist goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalNames();
        int goalIndex;
        while (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid goal number, try again.");
        }

        Goal goal = _goals[goalIndex - 1];
        goal.RecordEvent();
        Console.WriteLine($"Event recorded for goal: {goal._name}");
    }

    public void SaveGoals()
    {
        Console.Write("Enter the file name to save the goals: ");
        string fileName = Console.ReadLine();
        

        using (StreamWriter writer = new StreamWriter(fileName))
        {
           foreach (var goal in _goals)
           {
              writer.WriteLine($"{goal._name},{goal._description},{goal.IsComplete},{goal._points}");
           }
        }

    }
        
    

    public void LoadGoals()
    {
        Console.Write("Enter the file name to load the goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] goalData = line.Split(',');
                string _name = goalData[0];
                string _description = goalData[1];
                bool _isComplete = bool.Parse(goalData[2]);
                int _points = int.Parse(goalData[3]);

                //Goal goal = new Goal(_name,_description,_isComplete,_points);
               // _goals.Add(goal);
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}




    


