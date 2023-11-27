using System;

public class Activity
{
    protected string _startMessage;
    protected int _duration;
    protected string _EndMessage;

   
    public Activity (string startMessage, string endMessage)
    {
        _startMessage = startMessage;
        _EndMessage = endMessage;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine(_startMessage);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine(_EndMessage);
    }
    public void ShowAnimation(int duration)
    {
        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string[] animation = {"|", "/", "-", "\\",};
            foreach(string a in animation)
            {
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int duration)
    {
        for (int i = duration ; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
}