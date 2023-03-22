class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        // Create some videos
        var video1 = new Video()
        {
            Title = "How to Make a Cake",
            Author = "Jane Smith",
            Length = 1200, // 20 minutes
            Comments = new List<Comment>()
            {
                new Comment() { Name = "John", Text = "Great recipe, thanks for sharing!" },
                new Comment() { Name = "Sarah", Text = "I'm definitely trying this out!" }
            }
        };

        var video2 = new Video()
        {
            Title = "Gardening Tips for Beginners",
            Author = "Mike Johnson",
            Length = 1800, // 30 minutes
            Comments = new List<Comment>()
            {
                new Comment() { Name = "Mary", Text = "I never knew about planting, thanks for the tip!" },
                new Comment() { Name = "Bob", Text = "This was really helpful, keep up the good work!" },
                new Comment() { Name = "Jen", Text = "Can you do another video?" }
            }
        };

        var video3 = new Video()
        {
            Title = "10 Minute Yoga Routine",
            Author = "Samantha Lee",
            Length = 600, // 10 minutes
            Comments = new List<Comment>()
            {
                new Comment() { Name = "Emily", Text = "This was a great way to start my day, thanks!" },
                new Comment() { Name = "Jack", Text = "I'm new to yoga and this was perfect for me, thanks!" }
            }
        };

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video info and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Name: {comment.Name}");
                Console.WriteLine($"Text: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}

