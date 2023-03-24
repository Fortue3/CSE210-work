using System;
using System.Collections.Generic;

namespace YoutubeVideoComments
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of videos
            List<Video> videos = new List<Video>();

            // create 3-4 videos and add them to the list
            Video video1 = new Video("Introduction to C# Tutorial", "Fortunate Kwenda", 120);
            video1.AddComment("Ronald Green", "Great video!");
            video1.AddComment("Leilah Shumba", "I learned a lot.");

            Video video2 = new Video("Database Management Tutorial", "Richard Kwenda", 180);
            video2.AddComment("James Dube", "Interesting topic.");
            video2.AddComment("Lionel Messi", "Thanks for sharing.");

            Video video3 = new Video("Docker and Kubernetes Tutorial", "Tinashe Kwenda", 90);
            video3.AddComment("Christiano Ronaldo", "Could you explain this more?");
            video3.AddComment("Eva Mendez", "I have a question.");

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // iterate through the list of videos and display their information
            foreach (Video video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length: " + video.Length + " seconds");
                Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine(comment.CommenterName + ": " + comment.CommentText);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    // the Comment class for tracking comment information
    public class Comment
    {
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }
    }

    // the Video class for tracking video information and comments
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public void AddComment(string commenterName, string commentText)
        {
            Comments.Add(new Comment(commenterName, commentText));
        }

        public int GetNumberOfComments()
        {
            return Comments.Count;
        }
    }
}


