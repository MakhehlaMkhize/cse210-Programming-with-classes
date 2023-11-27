using System;
using System.Net.Sockets;

public class ReflectionActivity:Activity
{
    private List<string> _prompts = new();
    private List<string> _questions = new();
    public ReflectionActivity(string startMessage, string endMessage) : base(startMessage, endMessage)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public string GetRandomPrompt()
    {
        Random random = new();

        int randomIndex = random.Next(_prompts.Count);

        string prompt = _prompts[randomIndex];
    
        return prompt;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n\n---{GetRandomPrompt()}---");
    }
    public string GetRandomQuestion()
    {
        Random random = new();
        
        int randomIndex = random.Next(_questions.Count);

        string question = _questions[randomIndex];

        return question;
    }
    public void DisplayQuestions(int duration)
    {
        DateTime startTime  = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowCountDown(9);
        }
    }
    public void RunReflectionActivity()
    {
        Console.WriteLine();
        DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for our session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowAnimation(3);
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        while ( userInput != "")
        {
            Console.WriteLine("");
        }
        if (userInput == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write($"You may begin in: ");
            ShowCountDown(5);
            Console.Clear();
            DisplayQuestions(_duration);
        }

        Console.WriteLine();
        DisplayEndMessage();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of Breathing Activity\n");
        ShowAnimation(3);
    }
}
