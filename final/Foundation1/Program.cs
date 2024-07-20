using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("A fairy Tale", "Tamba Conteh", 30);
        Video video2 = new Video("Cooking Tomato Stew", "Bob Sheriff", 25);
        Video video3 = new Video("Travel the World", "Timothy Jones", 29);


        video1.AddComment("Mohamed Barrie", "Brilliant Video with a great message");
        video1.AddComment("Joe Sanccoh", " I have a hard time making sense of it.");
        video1.AddComment("Mohamed Barrie", "This is entertaining");

        video2.AddComment("David Bright", "Love this recipe.");
        video2.AddComment("Eva Musa", "Can't wait to try this out.");
        video2.AddComment("Frank Mark", "Looks delicious!");

        video3.AddComment("George Konowa", "Amazing vlog!");
        video3.AddComment("Hannah Macarthy", "Great places you visited.");
        video3.AddComment("Ayo Jones", "Thanks for sharing.");


        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}, Author: {video._author}, Length: {video._length} seconds, comments: {video.GetCommentCount()}");
            foreach (var comment in video.GetCommentList())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }

    }
}