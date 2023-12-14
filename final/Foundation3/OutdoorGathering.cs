using System;

public class OutdoorGathering : Event
{
    public string _weatherForecast;

    public OutdoorGathering(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }
    public override void DisplayFullDetails()
    {
        DisplayStandardDetail();
        Console.WriteLine($"Event Type: {GetType()}\nWeather Forecast: {_weatherForecast}\n");
    }

}