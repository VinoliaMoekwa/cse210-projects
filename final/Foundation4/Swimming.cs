using System;

public class Swimming : Activity
{
    private int _numberoflaps;

    public Swimming(DateTime date, int lengthInMinutes, int numberoflaps)
    : base(date, lengthInMinutes)
    {
        _numberoflaps = numberoflaps;
    }

    public override double GetDistance()
    {
        return _numberoflaps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / 60.0;
    }

    public override double GetPace()
    {
        return base._lengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}


