using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new();
        video1._videoTitle = "Cats playing cards";
        video1._videoAuthor = "Tom Riddle";
        video1._videoLength = 5;
        Comment video1Comment1 = new();
        video1Comment1._commenterName = "Jimmy";
        video1Comment1._comment = "What a funny video.";
        Comment video1Comment2 = new();
        video1Comment2._commenterName ="Bobby";
        video1Comment2._comment = "Is that a real cat?";
        Comment video1Comment3 = new();
        video1Comment3._commenterName = "Johnny";
        video1Comment3._comment = "Lets get that cat to be our President.";
        Comment video1Comment4 = new();
        video1Comment4._commenterName = "Sally";
        video1Comment4._comment = "Cats are so cool";

        List<Comment>video1Comments = new();
        video1Comments.Add(video1Comment1);
        video1Comments.Add(video1Comment2);
        video1Comments.Add(video1Comment3);
        video1Comments.Add(video1Comment4);

        Video video2 = new();
        video2._videoTitle = "Why Joseph was a true Prophet.";
        video2._videoAuthor = "Nephi son of Lehi";
        video2._videoLength = 30;
        Comment video2Comment1 = new();
        video2Comment1._commenterName = "Moroni";
        video2Comment1._comment = "What a powerful clip";
        Comment video2comment2 = new();
        video2comment2._commenterName = "John";
        video2comment2._comment = "The knowledge of such things can only come through the Sprit.";
        Comment video2Comment3 = new();
        video2Comment3._commenterName = "Peter";
        video2Comment3._comment = "I have always known this was true.";

        List<Comment>video2Comments = new();
        video2Comments.Add(video2Comment1);
        video2Comments.Add(video2comment2);
        video2Comments.Add(video2Comment3);

        Video video3 = new();
        video3._videoTitle = "How to loose belly fat";
        video3._videoAuthor = "Captain Moroni";
        video3._videoLength = 7;
        Comment video3Comment1 = new();
        video3Comment1._commenterName = "King Noah";
        video3Comment1._comment = "What a hard workout.";
        Comment video3Comment2 = new();
        video3Comment2._commenterName = "Nehor";
        video3Comment2._comment = "What a waste of my time. This is for weaklings";
        Comment video3Comment3 = new();
        video3Comment3._commenterName = "Kakarot";
        video3Comment3._comment = "Well done Captain! This the way to go.";

        List<Comment>video3Comments = new();
        video3Comments.Add(video3Comment1);
        video3Comments.Add(video3Comment2);
        video3Comments.Add(video3Comment3);
        
    
        List<Video>videoList = new();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        List<List<Comment>>allComments = new();
        allComments.Add(video1Comments);
        allComments.Add(video2Comments);
        allComments.Add(video3Comments);

        for (int i = 0 ; i < videoList.Count; i++)
        {
            Console.WriteLine();
            videoList[i].PlayVideo();
            Console.WriteLine($"{allComments[i].Count} comments");
            for( int j = 0 ; j < allComments[i].Count; j++)
            {
                Console.WriteLine();
                allComments[i][j].DisplayComment();
            }
        }

        
        
    }
}