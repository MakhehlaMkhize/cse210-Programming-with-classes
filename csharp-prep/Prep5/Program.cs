using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResults(PromptUserName(), SquaredNumber(PromptUserNumber()));

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber ()
        {
            Console.Write("What is your favourite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquaredNumber ( int number)
        {
            int squaredNumber = number*number;
            return squaredNumber;
        }
        static void DisplayResults(string name, int squared)
        {
            string userNamer = name;

            int squaredNumber = squared;

            Console.WriteLine($"{name}, the square of  your number is {squared}.");

        }
    }
}