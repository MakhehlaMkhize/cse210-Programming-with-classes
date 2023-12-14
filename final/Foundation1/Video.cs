using System;

public class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength;

    public void PlayVideo()
    {
        Console.WriteLine($"Video Title: {_videoTitle}\nVideo Author: {_videoAuthor}\nVideo Length: {_videoLength} min");
    }


}