using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company ="Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._jobTitle = "Web Programmer";
        job2._company = "Apple";
        job2._startYear = 2024;
        job2._endYear = 2027;

        Resume myResume = new Resume();
        myResume._name = "Tonny Lime";

        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.Dispay();
=======
        Journal journal = new Journal();
        
        Console.WriteLine(" Welcome to Today journal writing!");

        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Add Entry");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            //propmpt user to select option
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();
            // call class method
            switch (choice)
            {
                // add new entry to the journal
                case "1":
                journal.AddEntry();
                break;

                // display added entry
                case "2":
                journal.DisplayEntries();
                break;

                
                // load entries from a file
                case "3":
                journal.LoadFromFile();
                break;

                // save entries to a file
                case "4":
                journal.SaveToFile();
                break;

                // exit
                case "5":
                Console.WriteLine("quit!");
                break;

                // wrong choice selection
                default:
                Console.WriteLine("Wrong choice, Please enter a number between 1-5." );
                break;
            }
        }
>>>>>>> 2a58bd2b5d412134ca9b1dd0b9514b345773fb54
    }
}