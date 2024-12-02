using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.setStudentName("Tonny Lime");
        assignment1.setTopic("Multiplication");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.setTextBookSection("Section 7.3");
        assignment2.setProblems("Problems 8-19");

        Console.WriteLine(assignment2.GetHomeWorkList());

        HomeWorkAssgnment assgnment3 = new HomeWorkAssgnment();
        assgnment3.setStudentName("Mary Waters");
        assgnment3.setTitle("The Causes of World War II");
        

        Console.WriteLine(assgnment3.GetWritingInformation());


    }
}