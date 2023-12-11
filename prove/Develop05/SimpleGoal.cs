using System;


public class SimpleGoals : Goal
{
    public SimpleGoals()
    {
    }
    public SimpleGoals(string name, string description, int points, bool complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = complete;
    }   
    public override string GetDetailsString()
    {
        return $"{GetShortName()}:{GetDescription()}:{GetPoints()}:{IsComplete()}";
    }
    public override string GetStringRepresentation()
    {   
        if(IsComplete() == true)
        {
            return $"[X] {GetShortName()} ({GetDescription()})";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()})";
        }
    }
}
