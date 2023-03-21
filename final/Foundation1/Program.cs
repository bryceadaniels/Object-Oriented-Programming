using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        Comment comment1_1 = new Comment("Person1","Comment1");
        Comment comment1_2 = new Comment("Person2","Comment2");
        Comment comment1_3 = new Comment("Person3","Comment3");
        comments1.Add(comment1_1);
        comments1.Add(comment1_2);
        comments1.Add(comment1_3);
        Video vid1 = new Video("Video1","Author1",30,comments1);
        videos.Add(vid1);

        List<Comment> comments2 = new List<Comment>();
        Comment comment2_1 = new Comment("Person1","Comment1");
        Comment comment2_2 = new Comment("Person2","Comment2");
        Comment comment2_3 = new Comment("Person3","Comment3");
        comments2.Add(comment2_1);
        comments2.Add(comment2_2);
        comments2.Add(comment2_3);
        Video vid2 = new Video("Video2","Author2",60,comments2);
        videos.Add(vid2);

        List<Comment> comments3 = new List<Comment>();
        Comment comment3_1 = new Comment("Person1","Comment1");
        Comment comment3_2 = new Comment("Person2","Comment2");
        Comment comment3_3 = new Comment("Person3","Comment3");
        comments3.Add(comment3_1);
        comments3.Add(comment3_2);
        comments3.Add(comment3_3);
        Video vid3 = new Video("Video3","Author3",100,comments3);
        videos.Add(vid3);

        foreach(Video video in videos)
        {
            video.Display();
        }
    }
}