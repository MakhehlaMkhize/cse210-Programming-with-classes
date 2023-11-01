using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");

        int gradePercentage = int.Parse(Console.ReadLine());

        int lastDigit = gradePercentage%10;

        string letter = " ";

        string symbol = " ";

        if (lastDigit >=7 || gradePercentage == 100)
        {
            symbol = "+";
        }
        else if (lastDigit <3)
        {
            symbol = "-";
        }
        else
        {
            symbol = " ";
        }
        if ( gradePercentage >= 90)
        {   
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"You got a '{letter}{symbol}'");
            Console.WriteLine("Congratulations you passed the course!");
        }
        else if(gradePercentage>=60)
        {
            Console.WriteLine($"You got a '{letter}{symbol}'.");
            Console.WriteLine("Regret to inform you that you did not pass. Try again next time.");
        }
        else
        {
            Console.WriteLine($"You got a '{letter}'.");
            Console.WriteLine("Regret to inform you that you did not pass. Try again next time.");
        
        }
    }
}