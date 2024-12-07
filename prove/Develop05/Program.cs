using System;

Activity activity = new Activity("Activity", "This Activity...", 10);
string name = activity.GetName();
activity.setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
int duration = activity.GetDuration();
Console.WriteLine(name);
Console.WriteLine(duration);



BreathingActivity activity2 = new BreathingActivity("Breathing Activity", "This Activity..", 30);
activity2.setDescription("This activity will help you relax by walking your through breathing  in and out slowly. Clear your mind and focus on your breathing.");
activity2.setDuration(6000);
Console.WriteLine("Breath in...");



List<string> animationStrings = new List<string>();
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");

foreach (string s in animationStrings)
{
    Console.Write(s);
    Thread.Sleep(1000);
    Console.Write("\b \b");
}
//ListingActivity activity3 = new ListingActivity("Listing Activity", "This activty ..", 30, 50, $"{_prompts}");


