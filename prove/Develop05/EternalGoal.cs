using System;

public class EternalGoals : Goal
{
    public EternalGoals()
    {
    }
    public EternalGoals(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }   
    public override string GetDetailsString()
    {
        return $"{GetShortName()}:{GetDescription()}:{GetPoints()}";
    }
    public override string GetStringRepresentation()
    {   
        return $"[ ] {GetShortName()} ({GetDescription()})";
    }
}