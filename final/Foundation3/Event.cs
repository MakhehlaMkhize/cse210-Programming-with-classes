using System;

public abstract class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private string _eventType;
   
    public Event()
    {

    }
    public void SetTitle(string title)
    {
        _eventTitle = title;
    }
    public string GetTitle()
    {
        return _eventTitle;
    }
    public void SetDescription(string description)
    {
        _eventDescription = description;
    }
    public string GetDescription()
    {
        return _eventDescription;
    }public void SetDate(string date)
    {
        _eventDate = date;
    }
    public string GetDate()
    {
        return _eventDate;
    }
    public void SetTime(string time)
    {
        _eventTime = time;
    }
    public string GetTime()
    {
        return _eventTime;
    }
    public void SetType(string type)
    {
        _eventType = type;
    }
    public string GetEvent()
    {
        return _eventType;
    }
    public void DisplayStandardDetail()
    {
        Console.WriteLine($"Title: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDate}\nTime: {_eventTime}\n");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_eventDate}\n");
    }
    public abstract void DisplayFullDetails();
}