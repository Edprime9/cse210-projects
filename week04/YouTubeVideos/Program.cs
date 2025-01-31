using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("HTML Basics Tutorial", "W3Schools", 600);
        Video video2 = new Video("Advanced C# Programming", "Programiz", 1200);
        Video video3 = new Video("Understanding CSS Concepts", "Udemy", 900);

        // Add comments to video 1
        video1.AddComment(new Comment("Pauline", "Great explanation!"));
        video1.AddComment(new Comment("Steve", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Boateng", "Clear and concise."));

        // Add comments to video 2
        video2.AddComment(new Comment("Moroni", "Loved the depth of the topic!"));
        video2.AddComment(new Comment("Atisi", "Can you make more like this?"));
        video2.AddComment(new Comment("Tamunotonye Gogo", "Super useful for my project."));

        // Add comments to video 3
        video3.AddComment(new Comment("Miriam", "OOP is finally making sense!"));
        video3.AddComment(new Comment("Jerry", "This was the best explanation so far."));
        video3.AddComment(new Comment("Murphy", "Thanks for breaking it down."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}