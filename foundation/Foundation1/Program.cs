using System;


class Program
{
    static void Main(string[] args)
    {
         // Create a new video
        Video video1 = new Video("Learning intro C#", "This video explains C# basics.", 20);

        // Add some comments to the video
        video1.AddComment(new Comment("Tonny ", "Great video! U r a nice teacher."));
        video1.AddComment(new Comment("Lime ", "I found it a bit hard to follow. Could use more examples."));

        Video video2 = new Video("Learning  Abstraction in  C#", "This video explains how to simplify codes in  C# .",30);

        // Add some comments to  video2
        video2.AddComment(new Comment("Tonny ", "Great video! How I wish I was knowledgeble like you."));
        video2.AddComment(new Comment("Lime ", "Wow now I get it. You've made my day"));
        video2.AddComment(new Comment("Lumwaji ", "Finally I got it"));

        Video video3 = new Video("Learning  Encapsulation inC#", "This video explains how to hide some code in C# .", 60);

        // Add some comments to video3
        video3.AddComment(new Comment("Tonny ", "Why  is it always changing what is the aim?."));
        video3.AddComment(new Comment("job ", "Tonny, it is changing coz you need to know how to privatize you variables."));

        // Display video information along with comments
        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
        Console.WriteLine($"Number of  comments: {video1.GetCommentNumber()}");
        Console.WriteLine($"Number of  comments: {video2.GetCommentNumber()}");
        Console.WriteLine($"Number of  comments: {video3.GetCommentNumber()}");
    }
        
}
