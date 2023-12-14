using System;

public class Comment
{
    public string _commenterName;
    public string _comment;

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_commenterName}\n{_comment}");
    }
}