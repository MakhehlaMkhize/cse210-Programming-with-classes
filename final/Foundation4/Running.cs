using System;

public class Running : Activity
{
    private double _distance;
    public Running(int time, string activity, int distance): base(time , activity)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return Math.Round(_time/ _distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance * 60 / _time , 2);
    }

    
}