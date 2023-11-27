using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string startMessage, string endMessage) : base(startMessage, endMessage)
    {
    }
    private void BreathingAnimation(int duration)
    {   
        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime )
        {
            string[] animation = {"Breathe in...\n('o')", "Now Breathe out...\n(-_-)"};
            foreach(string a in animation)
            {
                Console.Clear();
                Console.Write(a);
                Thread.Sleep(4000);
            }
        }
    }
    public void RunBreathingActivity()
    {
        DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for our session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowAnimation(4);
        BreathingAnimation(_duration);
        Console.WriteLine();
        DisplayEndMessage();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of Breathing Activity.");
        ShowAnimation(3);
    }

}