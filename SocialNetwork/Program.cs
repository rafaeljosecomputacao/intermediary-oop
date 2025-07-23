using System;
using SocialNetwork.Entities;

namespace SocialNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(
                DateTime.Parse("14/07/2025 14:02:34"),
                "Traveling to New York",
                "I'm going to visit this wonderful country",
                20);
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("20/07/2025 22:00:16"),
                "Good night guys",
                "See you tomorrow",
                12);
            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the force be with you!");
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
