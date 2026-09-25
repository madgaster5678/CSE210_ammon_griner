using System;

public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"Address: {_streetAddress}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        } 
        else
        {
            return false;
        }
        
    }


}