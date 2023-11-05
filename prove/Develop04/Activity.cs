using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Activity{
   private string _activityName;
   private string _description;
   private int _duration;

   public Activity(string activityName, string description, int duration)
   {
    _activityName = activityName;
    _description = description;
    _duration = duration;
   }


public string GetActivityName()
{
    return _activityName;
}

public string GetDescription()
{
    return _description;
}

public int GetDuration()
{
    return _duration;
}

public void SetDuration(int duration)
{
    _duration = duration;
}

public void DisplayStartMessage()
{
Console.WriteLine($"Start: {_activityName}");
Console.WriteLine($"Description: {_description}");
Console.WriteLine($"The timer has been set to {_duration}, please get ready to start!");
CountdownWithSpinner(_duration);
}

public void CountdownWithSpinner(int _duration)
{
    string[] spinner = { "-", "/", "|", "\\" };
    int spinnerIndex = 0;

    for (int i = _duration; i >= 0; i--)
    {
        Console.Write($"Countdown: {spinner[spinnerIndex]} {i} {" ".PadRight(30)}\r");
        spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        Thread.Sleep(1000);
    }

}

public void DisplayEndMessage()
{
    Console.WriteLine($"Good job! You have completed the {_activityName} activity in {_duration} seconds!");

    
}
}
