using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Paper Mario Randomizer", "Bringlescan", 5059);
        Comment comment1 = new Comment("Rember that the super boots lets groundpound", "Marth");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("Watching them run around randomly is painful", "Astronotter");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("This is fun to watch", "Shadow_Queen");
        video1.AddComment(comment3);

        Video video2 = new Video("Wildlife in Australia", "Moreparz", 2285);
        Comment comment4 = new Comment("'We have eagles that hunt kangaroos don't worry about it' well now i am worring about it", "ImCade");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("This man's editing style is great", "Interndotgif");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Rest in peace Steve Irwin indeed", "Crocdileman");
        video2.AddComment(comment6);

        Video video3 = new Video("Plot Twists that shocked us!", "PD TV", 5485);
        Comment comment7 = new Comment("Ice tea is a great actor", "Mad_gaster34");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("Episodes like these are why some people distrust cops", "Superman56");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("the way some people acting like they are the victum makes me sick", "Batfam90");
        video3.AddComment(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideo());
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayComment());
            }
            Console.WriteLine();
        }

    }
}