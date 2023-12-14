using System;

public class Cycling : Activity
{
    private double _speed;
    public Cycling(int time, string activity, double speed) : base(time, activity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _time / 60;
    }

    public override double GetPace()
    {
        return _time/GetDistance();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

}