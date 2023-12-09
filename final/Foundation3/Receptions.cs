using System;
using System.Runtime.CompilerServices;

public class Receptions : Event
{
    private string _email;

    public Receptions(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string email)
      : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $" {base.GetFullDetails()}\nType: Reception\n RSVP :{_email}";
    }

}