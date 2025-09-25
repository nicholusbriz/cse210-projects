using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create 3-4 videos
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful"));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing"));
        videos.Add(video1);

        Video video2 = new Video("ASP.NET Basics", "Jane Smith", 800);
        video2.AddComment(new Comment("David", "Clear explanation"));
        video2.AddComment(new Comment("Eva", "Well structured"));
        video2.AddComment(new Comment("Frank", "Good examples"));
        video2.AddComment(new Comment("Grace", "Easy to follow"));
        videos.Add(video2);

        Video video3 = new Video("SQL for Beginners", "Mike Johnson", 450);
        video3.AddComment(new Comment("Henry", "Perfect for beginners"));
        video3.AddComment(new Comment("Ivy", "Concise and clear"));
        video3.AddComment(new Comment("Jack", "Helpful tutorial"));
        videos.Add(video3);

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}