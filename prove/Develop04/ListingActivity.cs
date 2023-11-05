using System;
using System.Collections.Generic;

public  class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {   
        base.DisplayStartMessage(); 

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void StartListingActivity()
{

    string selectedPrompt = GetRandomPrompt();
    Console.WriteLine(selectedPrompt);

    int remainingDuration = GetDuration();
    int itemCounter = 0;

    bool continueListing = true;

    while (remainingDuration > 0 && continueListing)
    {
        Console.Write("> ");
        string item = Console.ReadLine();
        itemCounter++;
        remainingDuration -= 4;

        if (remainingDuration <= 0)
        {
            break; // Exit the loop if the duration is reached
        }

        Console.Write("Do you want to continue listing items? (Y/N): ");
        string userInput = Console.ReadLine().Trim().ToUpper();
        if (userInput != "Y")
        {
            continueListing = false;
        }
    }

    Console.WriteLine($"You listed {itemCounter} items.");
    base.DisplayEndMessage(); 
}



    private string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    
}
