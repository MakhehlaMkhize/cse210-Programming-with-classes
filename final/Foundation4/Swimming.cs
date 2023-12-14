using System;

public class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(int time, string activity, int numberOfLaps) : base(time, activity)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        return _time / GetDistance(); 
    }

    public override double GetSpeed()
    {
        return 60 / GetPace(); 
    }
}