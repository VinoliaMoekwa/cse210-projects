using System;

public class OutdoorGatherings : Event
{
    private string _weatherforecast;

    public OutdoorGatherings(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string weatherforecast)
    : base(eventTitle, description, date, time, address)
    {
        _weatherforecast = weatherforecast;
    }

    public override string GetFullDetails()
    {
        return $" {base.GetFullDetails()}\nType: Reception\n Weather Forecast :{_weatherforecast}";
    }

}
