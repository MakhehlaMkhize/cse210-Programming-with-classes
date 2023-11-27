using System;

public class ListingActivity : Activity 
{

    private int _count;
    private List<string> _prompts = new();

    public ListingActivity(string startMessage, string endMessage) : base(startMessage, endMessage)
    {
        _count = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void GetRandomPrompt()
    {
        Random random = new();

        int randomIndex = random.Next(_prompts.Count);

        string prompt = _prompts[randomIndex];
    
        Console.WriteLine(prompt);
    }
    public List<string> GetListFromUser(int duration)
    {
        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        List<string> userList = new();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
        }
        return userList;
    }
    public void RunListingActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.Write("\nHow long, in seconds, would you like for our session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowAnimation(3);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        _count= GetListFromUser(_duration).Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndMessage();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of Breathing Activity\n");
        ShowAnimation(3);
    }
}