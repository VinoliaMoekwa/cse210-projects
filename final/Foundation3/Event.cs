using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Globalization;

public class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string GetStandardDetails()
    {

        return $"Title: {_eventTitle}\nDescription: {_description}\n Date: {_date.ToShortDateString()}\n Time: {_time}\n  {_address.GetAddressDetails()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDetails()
    {
        return $"Type: {GetType().Name}, Title: {_eventTitle}, Date: {_date.ToShortDateString()}";
    }

}