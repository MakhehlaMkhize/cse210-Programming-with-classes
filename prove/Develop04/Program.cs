using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        
        int userInput = 0;
        do
        {
            Menu menu = new();
            menu.GetMenuOptions();
            try{
                userInput = int.Parse(Console.ReadLine());
            }catch(Exception)
            {
                Console.WriteLine("Incorrect input! Select a number 1-4:\n");
            }finally
            {
                if (userInput > 5){
                    Console.WriteLine("Incorrect input! Select a number 1-4:\n");
                }
            }
            if ( userInput == 1)
            {
                BreathingActivity breathingActivity = new("Welcome to the Breathing Activity\n\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Well done!");

                breathingActivity.RunBreathingActivity();
            }  
            else if ( userInput ==2)
            {
                ReflectionActivity reflectionActivity = new("Welcome to the Reflection Activity\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Well done!");

                reflectionActivity.RunReflectionActivity();

            }
            else if (userInput == 3)
            {
                ListingActivity listingActivity = new("Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Well done!=");

                listingActivity.RunListingActivity();
            }
        }while (userInput !=4);
        
        
                
    }
}