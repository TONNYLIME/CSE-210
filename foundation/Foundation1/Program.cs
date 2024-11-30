using System;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "xyx";
        video1._author = "kenya";
        video1._length = 3;


        Video video2 = new Video();
        video2._title = "pgg";
        video2._author = "ktn";
        video2._length = 3;
        


        Video video3 = new Video();
        video3._title = "klm";
        video3._author = "ctz";
        video3._length = 3;


        Comment myComment = new Comment();
        myComment._name = "Tonny";
        myComment._videos.Add(video1);
        myComment._videos.Add(video2);
        myComment._videos.Add(video3);

        myComment.Display();
    }
}
