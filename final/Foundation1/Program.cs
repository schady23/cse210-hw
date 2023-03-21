using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos and comments
        Video video1 = new Video()
        {
            Title = "Cat Video",
            Author = "CatLover123",
            LengthInSeconds = 60,
            Comments = new List<Comment>()
            {
                new Comment() { CommenterName = "CatHater", Text = "I hate cats!" },
                new Comment() { CommenterName = "CatLover", Text = "This is the best cat video ever!" },
                new Comment() { CommenterName = "MouseLover", Text = "Cats are cute, but I prefer mice." },
                new Comment() { CommenterName = "Neil89", Text = "Cats eat mice dude."}
            }
        };

        Video video2 = new Video()
        {
            Title = "Dog Video",
            Author = "DogLover123",
            LengthInSeconds = 120,
            Comments = new List<Comment>()
            {
                new Comment() { CommenterName = "DogHater", Text = "Dogs are stupid." },
                new Comment() { CommenterName = "DogLover", Text = "This video always makes me laugh." },
                new Comment() { CommenterName = "BunnyLover", Text = "I like dogs, but bunnies are cuter." }
            }
        };

          Video video3 = new Video()
        {
            Title = "I did a triple Backflip",
            Author = "HumanBicycle",
            LengthInSeconds = 180,
            Comments = new List<Comment>()
            {
                new Comment() { CommenterName = "LoverofMen", Text = "I like men." },
                new Comment() { CommenterName = "IDontbelieveyou", Text = "I don't beleive you." },
                new Comment() { CommenterName = "JUAN_CENA", Text = "definitly photoshopped" },
                new Comment() { CommenterName = "PeanutOfferer", Text = "Want a peanut?"}
            }
        };

        // Add videos to a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information about each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: {0}", video.Title);
            Console.WriteLine("Author: {0}", video.Author);
            Console.WriteLine("Length: {0} seconds", video.LengthInSeconds);
            Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- {0}: {1}", comment.CommenterName, comment.Text);
            }
            Console.WriteLine();
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}