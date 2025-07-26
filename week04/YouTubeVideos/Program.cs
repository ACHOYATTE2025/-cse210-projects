using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Comment> comments = new List<Comment>();
        List<Video> videos = new List<Video>();

        Comment comment1 = new Comment("CLARK", "I am  Computer  Engineer");
        Comment comment2 = new Comment("HELLEN", "I like Nursing");
        Comment comment3 = new Comment("JOHN", "I am soldier");
        Comment comment4 = new Comment("JUNIOR", "I love eveyone");

        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        comments.Add(comment4);

        Video video1 = new Video("VISIT USA", "JEFFREY", 25, comments);
        Video video2 = new Video("FRANCE FLOWER", "MOUTON", 15, comments);
        Video video3 = new Video("JAPAN SUSHI", "HONDA", 35, comments);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var item in videos)
        {
            Console.WriteLine($"Tile: {item.getTitle()}");
            Console.WriteLine($"Author: {item.getAuthor()}");
            Console.WriteLine($"Length: {item.getLength()}");
            Console.WriteLine($"Comment's Number: {item.getNumberOfComment()}");

            foreach (var items in item.getComments())
            {

                Console.WriteLine($"{items.getText()}");
            }
             Console.WriteLine($"=============================");
        }



    }
}