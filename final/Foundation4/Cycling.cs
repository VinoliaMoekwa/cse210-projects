using System;

public class Cycling : Activity
{
    private double _speed;


    public Cycling(DateTime date, int lengthInMinutes, double speed)
    : base(date, lengthInMinutes)
    {
        _speed = speed;

    }


    public override double GetDistance()
    {
        return _speed / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} miles,  Speed: {_speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }

}




