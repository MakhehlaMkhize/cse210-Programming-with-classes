using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;
    public Goal()
    {
       
    }
    public void SetShortName()
    {
        Console.Write("What is the name of your Goal? ");
        _shortName = Console.ReadLine();
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public void SetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = int.Parse(Console.ReadLine());
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual void SetIsComplete()
    {
        _isComplete = true;
    }
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    public abstract string GetDetailsString();
    
    public abstract string GetStringRepresentation();
}