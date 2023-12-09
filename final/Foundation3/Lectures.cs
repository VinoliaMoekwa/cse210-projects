using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
    : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker:{_speaker}\nCapacity:{_capacity}";
    }

}













