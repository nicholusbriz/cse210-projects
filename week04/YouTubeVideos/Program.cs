using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "Nicholus", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));
        videos.Add(video1);

        Video video2 = new Video("Design Principles", "Nicholus", 420);
        video2.AddComment(new Comment("Diana", "Loved the examples."));
        video2.AddComment(new Comment("Ethan", "Clear and concise."));
        video2.AddComment(new Comment("Fiona", "Awesome content."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction in OOP", "Nicholus", 360);
        video3.AddComment(new Comment("George", "This made it click."));
        video3.AddComment(new Comment("Hannah", "Perfect for beginners."));
        video3.AddComment(new Comment("Ian", "Well explained."));
        videos.Add(video3);

        Video video4 = new Video("C# Collections", "Nicholus", 280);
        video4.AddComment(new Comment("Jack", "Nice overview."));
        video4.AddComment(new Comment("Karen", "I learned a lot."));
        video4.AddComment(new Comment("Leo", "Keep it up!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
