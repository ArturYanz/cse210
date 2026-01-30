using System;
using System.Linq.Expressions;





// Arturo Yánez - Author
class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Loyal Warriors Walkthrough 1", "RexGamplays", 600);
        Comment comment1 = new Comment("xXtroling", "Your video is bad");
        Comment comment2 = new Comment("Sophia Williams", "I love Mandy! She's great");
        Comment comment3 = new Comment("Nub420", "Why is this soo short, make longer vids bro!");
        Comment comment4 = new Comment("WallyTek156", "I like your videos!");


        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);


        Video video2 = new Video("Dancing Monkeys", "Alex Twitt", 180);
        Comment comment5 = new Comment("Luciano García", "Good song");
        Comment comment6 = new Comment("Lilian850", "When are you comming to Europe???");
        Comment comment7 = new Comment("Sophia Williams", "I love your music <3");
        Comment comment8 = new Comment("Charzz1012", "BORING");

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);


        Video video3 = new Video("THE MOTH-MAN Official Trailer", "MARVEEL Entertainment", 190);
        Comment comment9 = new Comment("PeliVlog", "I can't wait to see this movie!");
        Comment comment10 = new Comment("ArthurTheGuy", "2027! I cannot wait a year!");
        Comment comment11 = new Comment("OfMyHead", "I hope Kevin Johnson will do a great job as Tim Timmothy");
        Comment comment12 = new Comment("Lilian850", "I'll watch this with my friends");


        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);



        Video video4 = new Video("Me At The Zoo", "jawed", 19);
        Comment comment13 = new Comment("Google", "Interesting");
        Comment comment14 = new Comment("DoglasD", "Almost 21 years of YouTube! WOW");
        Comment comment15 = new Comment("Jimmy1524", "I Was Here");
        Comment comment16 = new Comment("JoghCoat", "First comment");


        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);



        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine();
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }

    }
}