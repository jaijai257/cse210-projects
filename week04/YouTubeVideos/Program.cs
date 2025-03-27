using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();


       Video video1 = new Video("How to code with C#", "Alma Peters", 400);
       video1.AddComment(new Comment("Mark", "Great tutorial"));
       video1.AddComment(new Comment("Faith", "Very Informative"));
       video1.AddComment(new Comment("Pat", "I've learnt a lot, Thank you"));
       videos.Add(video1);
       

       Video video2 = new Video("Learning Abstraction", "Ron Smith", 650);
       video2.AddComment(new Comment("Mike", "Wow! I understand now"));
       video2.AddComment(new Comment("Faith", "Thank You, i'm grateful"));
       video2.AddComment(new Comment("Pat", "Finally understand it"));
       videos.Add(video2);


       Video video3 = new Video("Advanced C#", "Gray Patt", 850);
       video3.AddComment(new Comment("Mandy", "Wonderful tutorial, I'll keep practicing"));
       video3.AddComment(new Comment("Faith", "Thanks for explaining clearly"));
       video3.AddComment(new Comment("Pat", "This is a brilliant lesson can't wait to learn more "));
       videos.Add(video3);


        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}