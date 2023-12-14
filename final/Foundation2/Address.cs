using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address (string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void setCity(string city)
    {
        _city = city;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetState()
    {
        return _state;
    }
    public void setCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }
    public bool isUSA()
    {
        if ( _country == "USA")
        {
            return true;
        }
        return true;
    }
    public string GetAddress()
    {
        return($"{_streetAddress}\n{_city}\n{_state}\n{_country}");
    }
}