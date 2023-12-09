using System;
using System.Runtime.CompilerServices;

public class Address
{
    private string _street;
    private string _city;
    private string _country;

    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _country = country;
    }


    public string GetAddressDetails()
    {
        return $"Street: {_street}, City:{_city}, Country:{_country}";
    }

}