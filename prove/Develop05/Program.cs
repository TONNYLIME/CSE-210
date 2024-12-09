using System;
class Program
{
    
    static void Main(string[] args)
    {
        Activity activity1 = new Activity();
        while (true) {
            Console.WriteLine("Menu option:");
            Console.WriteLine(" 1.Breathing Activity");
            Console.WriteLine(" 2.Listing Activity");
            Console.WriteLine(" 3.Reflection Activity");
            Console.WriteLine(" 4.quit");
            //propmpt user to select option
            Console.WriteLine("Please select an option (1-4) ");
            string choice = Console.ReadLine();
            // call class method
            switch (choice)
            {
                // Select breathing activity
                case "1":
                Activity.BreathingActivity();
                break;

                // display added entry
                case "2":
                Activity.ListingActivity();
                break;

                
                // load entries from a file
                case "3":
                Activity.ReflectingActivity();
                break;

            

                // exit
                case "4":
                Console.Write("quit!");
                break;

                // wrong choice selection
                default:
                Console.WriteLine("Wrong choice, Please enter a number between 1-5." );
                break;
            }

        }
    }
    //activity1.setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");


//Console.WriteLine();




    



//List<string> animationStrings = new List<string>();
//animationStrings.Add("|");
//animationStrings.Add("/");
//animationStrings.Add("-");
//animationStrings.Add("\\");
//animationStrings.Add("|");
//animationStrings.Add("/");
//animationStrings.Add("-");
//animationStrings.Add("\\");

//foreach (string s in animationStrings)
//{
   // Console.Write(s);
   // Thread.Sleep(1000);
   // Console.Write("\b \b");
//}
//ListingActivity activity3 = new ListingActivity("Listing Activity", "This activty ..", 30, 50, $"{_prompts}");


       // Console.WriteLine("Menu option");
       // Console.WriteLine("  1 Start Breathing Activity.");
       // Console.WriteLine("  2 Start listing activity.");
       // Console.WriteLine("  3 Start reflecting activity.");
       // Console.WriteLine("  4 Quit.");
       // Console.WriteLine("Select a choice from the menu: ");

       //  Console.WriteLine("Breath out..");
       // Thread.Sleep(5000);
       // Console.WriteLine("Breath in...");
       // Thread.Sleep(5000);
       // Console.WriteLine("Breath out..");
       // Thread.Sleep(5000);
       // Console.WriteLine("Breath in...");
       // Thread.Sleep(5000);
       // Console.WriteLine("Breath out..");
       // Thread.Sleep(5000);
       // Console.WriteLine("Breath in...");
       // Thread.Sleep(5000);
       // Console.WriteLine("Breath out..");
       // Thread.Sleep(5000);
}


