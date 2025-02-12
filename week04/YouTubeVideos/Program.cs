using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        Video vid1 = new Video("HTML Basics Tutorial", "W3Schools", 600);
        Video vid2 = new Video("Advanced C# Programming", "Programiz", 1200);
        Video vid3 = new Video("Understanding CSS Concepts", "Udemy", 900);
        Video vid4 = new Video("Python","Youtude",500);
        
        List<Video> youtube = new List<Video>();
        youtube.Add(vid1);
        vid1._comments=["Awesome","Great","Nice brand","Wow how can i get that!"];
        Comment vidOne = new Comment();
        vidOne._name=["Andrew","fred","Joshua","John"];
        vidOne._text=["Thanks for simpliying it","super useful for my project","loved the depth of the topic","Wow how can i get that!"];
       
        youtube.Add(vid2);
        vid2._comments=["Pauline","Great","Nice brand"];
        Comment vidtwo = new Comment();
        vidtwo._name=["Andrew","James","Joshua"];
        vidtwo._text=["Awesome","Clear and concise","This was the best explanation so far"];

        foreach(var vid in youtube)
        {
            vid.Display();
            Console.WriteLine();
        }

        Console.WriteLine("Video One Comments");
        vidOne.displayComment();
        Console.WriteLine();

        Console.WriteLine("Video Two Comments");
        vidtwo.displayComment();

       
       
    }
}