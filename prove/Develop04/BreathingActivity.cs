using System;
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration)
    :base (activityName,description,duration) {

    }
    public void StartBreathingActivity()
{
    base.DisplayStartMessage();

    int remainingDuration = GetDuration();
    Console.Write("How long would you like to breathe for? (in seconds): ");
    if (int.TryParse(Console.ReadLine(), out int userDuration))
    {
        SetDuration(userDuration); 
        remainingDuration = GetDuration(); 
    }
    else
    {
        Console.WriteLine("Invalid input. Using the default duration.");
    }

    while (remainingDuration > 0)
    {
        PromptBreathingIn();
        base.CountdownWithSpinner(4);
        PromptBreathingOut();
        base.CountdownWithSpinner(4);
        remainingDuration -= 8;
    }

    base.DisplayEndMessage();
}

    
    public void PromptBreathingIn()
    {
        Console.WriteLine("Breathe in....");
    }

    public void PromptBreathingOut()
    {
        Console.WriteLine("Breathe out....");
    }
    
    
}