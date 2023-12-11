using System;
using System.IO;
using System.Net.WebSockets;
public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public GoalManager()
    {
        
    }
    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Goals\n6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points\n");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals )
        {
            Console.WriteLine($"{goal.GetStringRepresentation()}");
        }
    }   
    public void ListGoalDetails()
    {
        foreach ( Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        SimpleGoals simpleGoals = new();
        EternalGoals eternalGoals = new();
        CheckListGoal checkListGoal = new();

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");

        int userGoalChoice = int.Parse(Console.ReadLine());
        
        if(userGoalChoice == 1)
        {
            simpleGoals.SetShortName();
            simpleGoals.SetDescription();
            simpleGoals.SetPoints();
            _goals.Add(simpleGoals);
        }
        else if (userGoalChoice == 2)
        {
            eternalGoals.SetShortName();
            eternalGoals.SetDescription();
            eternalGoals.SetPoints();
            _goals.Add(eternalGoals);
        }
        else if (userGoalChoice == 3)
        {
            checkListGoal.SetShortName();
            checkListGoal.SetDescription();
            checkListGoal.SetPoints();
            checkListGoal.SetTarget();
            checkListGoal.SetBonus();
            _goals.Add(checkListGoal);
        }
    }
    public void RecordEvent()
    {
        
        Console.WriteLine($"The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
        
        Console.Write("Which goal did you accomplish? ");
        int userGoalCompleted = int.Parse(Console.ReadLine())-1;
        for (int i = 0 ; i < _goals.Count; i++)
        {
            if (userGoalCompleted == i)
            {
                Console.WriteLine($"Congratulations! you have earned {_goals[i].GetPoints()}\nYou now have {_goals[i].GetPoints()}");
                _score += _goals[i].GetPoints();   
                _goals[i].IsComplete();
            }
        }   
    }
    public void SaveGoals( string fileName)
    {
        String GoalsFile = fileName;

        using StreamWriter outputFile = new(GoalsFile);
        {
            outputFile.WriteLine(_score);
            foreach(Goal goalDesc in _goals)
            {
                outputFile.WriteLine($"{goalDesc.GetDetailsString()}"); 
            }  
            Console.WriteLine("\nThe list has been saved.");           
        }
    }
    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] goals = line.Split(":");
            
            if ( goals.Length == 4)
            {
                string shortName = goals[0];
                string description = goals[1];
                int points = int.Parse(goals[2]);
                bool isComplete = bool.Parse(goals[3]);
                SimpleGoals simpleGoals = new(shortName, description, points, isComplete);
                _goals.Add(simpleGoals);
            }
            if (goals.Length ==3)
            {
                string shortName = goals[0];
                string description = goals[1];
                int points = int.Parse(goals[2]);
                EternalGoals eternalGoals = new(shortName, description, points);
                _goals.Add(eternalGoals);
            }
            if (goals.Length == 7)
            {
                string shortName = goals[0];
                string description = goals[1];
                int points = int.Parse(goals[2]);
                bool isComplete = bool.Parse(goals[3]);
                int amountCompleted = int.Parse(goals[4]);
                int target = int.Parse(goals[5]);
                int bonus = int.Parse(goals[6]);
                CheckListGoal checkListGoal = new(shortName, description, points, isComplete, amountCompleted,target, bonus);
                _goals.Add(checkListGoal);
            }
        }
    }
}