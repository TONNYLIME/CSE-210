using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._jobTitle = "Electrical Technician";
        job1._company = "Subaru Kenya";
        job1._startYear = 2021;
        job1._endYear = 2025;
        job1.Display();

        Job job2 = new Job ();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2025;
        job2._endYear = 2028;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Tonny L.Lime";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


        

    }
}