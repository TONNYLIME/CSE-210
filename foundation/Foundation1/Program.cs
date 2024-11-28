using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "";
        video1._author ="";
        video1._length = 3;
        video1._comment ="";

        Video video2 = new Video();
        video2._title = "";
        video2._author ="";
        video2._length = 3;
        video2._comment ="";

        Video video3 = new Video();
        video3._title = "";
        video3._author ="";
        video3._length = 3;
        video3._comment ="";

        
        Comment myComment = new Comment();
        myComment._name = "Allison Rose";

        myComment._videos.Add(video1);
        myComment._videos.Add(video2);

        myComment.Display();
    }
}