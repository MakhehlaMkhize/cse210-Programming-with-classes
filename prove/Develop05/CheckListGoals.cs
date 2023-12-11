using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public CheckListGoal()
    {
    } 
    public CheckListGoal(string name, string description, int points, bool complete, int amountCompleted,int target, int bonus)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = complete;
        _target = target;
        _amountCompleted = amountCompleted;
        _bonus = bonus;
    }   
    public void SetTarget()
    {
        Console.WriteLine("How many times does this goal need to accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetAmountCompleted()
    {
        _amountCompleted += 1;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetBonus()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override string GetDetailsString()
    {
        return $"{GetShortName()}:{GetDescription()}:{GetPoints()}:{IsComplete()}:{GetAmountCompleted()}:{GetTarget()}:{GetBonus()}";
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
             _isComplete = true;
        }
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {   
        if(_isComplete == true)
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
}