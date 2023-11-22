using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Makhehla", "Mathematics" );
        string display = assignment.GetSummary();
        MathAssignment mathAssignment = new("Makhehla Mkhize","Mathematics","section 7.3", "Problem 8-19");
        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}