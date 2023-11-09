using System;

public class UserSelection
{
    public int _userSelection;
    public void DisplaySelection()
    {
        Console.WriteLine("Welcome to your Journal.");
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    
        _userSelection = int.Parse(Console.ReadLine());
    }
    
}