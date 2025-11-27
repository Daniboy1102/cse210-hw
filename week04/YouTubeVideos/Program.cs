using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video();
        v1.Title = "How to Bake Cookies";
        v1.Author = "BakingWithSam";
        v1.LengthSeconds = 300;
        v1.Comments.Add(new Comment("Alice", "Yummy!"));
        v1.Comments.Add(new Comment("Bob", "Trying this today."));
        v1.Comments.Add(new Comment("Charlie", "Turned out great!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video();
        v2.Title = "Learn C# Basics";
        v2.Author = "CodeMaster";
        v2.LengthSeconds = 600;
        v2.Comments.Add(new Comment("Derek", "Very helpful."));
        v2.Comments.Add(new Comment("Ella", "I finally understand classes!"));
        v2.Comments.Add(new Comment("Fred", "Great lesson."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video();
        v3.Title = "Top 5 Travel Tips";
        v3.Author = "TravelLife";
        v3.LengthSeconds = 400;
        v3.Comments.Add(new Comment("Gina", "These are useful!"));
        v3.Comments.Add(new Comment("Hank", "Loved tip #3."));
        v3.Comments.Add(new Comment("Ivy", "Planning my trip now!"));
        videos.Add(v3);

        // Display everything
        foreach (Video v in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($" - {c.Name}: {c.Text}");
            }
            Console.WriteLine();
        }
    }
}
