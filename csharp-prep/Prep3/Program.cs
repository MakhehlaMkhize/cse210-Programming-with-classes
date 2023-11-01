using System;

class Program
{
    static void Main(string[] args)
    {
        

        Boolean play = false;

        do{
            Random randomNumber = new Random();

            int magicNumber = randomNumber.Next(1,101);

            Console.WriteLine(magicNumber);

            int userGuess = 0;

            int guessCount = 0;
            do
            {
                guessCount++;

                Console.WriteLine("What is the magic magicNumber? ");

                Console.Write("What is your guess? \n");

                userGuess = int.Parse(Console.ReadLine());

                if ( userGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"\nYou guessed it in {guessCount } attempts");
                    
                    Console.Write("Would you like to play again? ");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        play = true;
                    }
                    else if (playAgain == "no")
                    {
                        Console.WriteLine("\nSee you next time. GoodBye!");
                        play = false;
                    }
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }while ( userGuess != magicNumber);
        }while (play == true );  
    }
}