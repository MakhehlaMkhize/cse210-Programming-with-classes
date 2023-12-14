using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity)
    {   
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void DisplayFullDetails()
    {
        DisplayStandardDetail();
        Console.WriteLine($"Event Type: {GetType()}\nSpeaker: {_speaker}\nAvailable Space: {_capacity} seats\n");
    }
}