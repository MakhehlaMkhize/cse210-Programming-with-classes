using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new();

        int userInput = 0;

        while (userInput != 6)
        {
            goalManager.DisplayPlayerInfo();

            goalManager.Start();

            userInput = int.Parse(Console.ReadLine());

            if  (userInput == 1)
            {
               goalManager.CreateGoal();
            }
            else if (userInput == 2)
            {
                goalManager.ListGoalNames();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("What would you like to save the file as?");
                string fileName = Console.ReadLine();
                goalManager.SaveGoals(fileName);
            }
            else if (userInput == 4)
            {   
                Console.WriteLine("What is the name of the file you would like to load?");
                
                string fileName = Console.ReadLine();

                goalManager.LoadGoals(fileName);
            }
            else if (userInput ==5)
            {
                goalManager.RecordEvent();
            }
        }
    }

}