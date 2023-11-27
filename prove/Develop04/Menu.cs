using System;

public class Menu
{
    private string _breathingActivity;
    private string _reflectionActivity;
    private string _listingActivity;
    private string _quit;
    public Menu()
    {
        _breathingActivity = "1. Breathing Activity";
        _reflectionActivity = "2. Reflection Activity";
        _listingActivity = "3. Listing Activity";
        _quit = "4. Quit";
    }
    public void GetMenuOptions()
    {   
        Console.WriteLine("Menu options:");
        Console.WriteLine($" {_breathingActivity}\n {_reflectionActivity}\n {_listingActivity}\n {_quit}");
        Console.WriteLine("Select a choice from the menu:");
    }
}