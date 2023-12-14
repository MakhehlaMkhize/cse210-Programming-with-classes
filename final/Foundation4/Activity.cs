using System;

public abstract class Activity
{
    private string _date;
    protected int _time;
    protected string _activity;

    public Activity(int time, string activity)
    {

        _time = time;
        _activity = activity;
    }
    public string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToString("dd MMM yyyy");
        return _date;
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public void GetSummary()
    {
        Console.WriteLine($"\n{GetDate()} {_activity} ({_time} min): Distance {GetDistance()} km, Speed: {GetSpeed()}Kph, Pace: {GetPace()} min per Km\n");
    }


}