using System;

public class ChecklistGoal: Goal 
{
    private int _requiredTimes;
    private int _bonusPoints;
    private int _timesCompleted;
    


public ChecklistGoal(string name, int points, int requiredTimes, int bonusPoints, string description,int timesCompleted)
    : base (name,points,description)
    {
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public int GetRequiredTimes()
    {
        return _requiredTimes;
    }
    public void SetRequiredTimes(int requiredTimes){
        _requiredTimes = requiredTimes;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetBonusPoint( int bonusPoints)
    {
  
        _bonusPoints = bonusPoints;

    }

    public int GetTimesCompleted()
  {
      return _timesCompleted;

  }

  public void SetTimesCompleted(int timesCompleted)
  {
    _timesCompleted = timesCompleted;
  }


    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    











}