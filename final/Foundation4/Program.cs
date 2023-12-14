using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new(45, "Running", 10);

        Cycling cycling = new(120, "Cycling", 40);
        
        Swimming swimming = new(30, "Swimming", 20);

        List<Activity> activities = new();
        activities.Add(swimming);
        activities.Add(cycling);
        activities.Add(running);

        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
        
    }
}