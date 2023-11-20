using System;

class Program
{   
    static void Main(string[] args)
    {
        Console.Clear();  
        Reference reference = new("John", 3, 16); 
    
        Scripture scripture = new(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        string userInput ="";

        Console.WriteLine(scripture.GetDisplayScripture());

        do
        {
            Console.WriteLine("\nPress enter to continue or type quit to finish:");
            
            userInput = Console.ReadLine().ToLower();
        
            if (userInput == "")
            {
                scripture.HideRandomWords(1);
            }
            else if ( userInput == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input! Press enter or type 'quit' to continue.");
            }
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayScripture());
            
        }while (scripture.IsCompletelyHidden()!= true); 
        
    }
}





