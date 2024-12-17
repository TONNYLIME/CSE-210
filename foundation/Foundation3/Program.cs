using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity 
        Activity running = new Running(new DateTime(2024, 12, 17), 40, 3.0); // 40 min, 3 miles
        Activity cycling = new Cycling(new DateTime(2024, 12, 17), 30, 20.0); // 30 min, 20 mph
        Activity swimming = new Swimming(new DateTime(2024, 12, 7), 10, 25); // 10 min, 25 laps

        // Store the activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through the list and display the summary of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}