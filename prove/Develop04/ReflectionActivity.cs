using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _reflections;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectionActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
        
    {
        base.DisplayStartMessage();
        _reflections = new List<string>

        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."

        
        };
        
        Console.WriteLine("Consider the following prompt:");
        DisplayRandomReflection();

        Console.WriteLine("When you have something in mind Press enter.");
        Thread.Sleep(5000);
        Console.ReadLine();
    
        
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        DisplayRandomQuestions();
        base.CountdownWithSpinner(8); 
        DisplayRandomQuestions();
        base.CountdownWithSpinner(4); 

        base.DisplayEndMessage();
    }

    public void RemainingDuration()
    {
        int remainingDuration = GetDuration();

        while (remainingDuration > 0)
        {
            remainingDuration -= 8;
        } 
    }

    public void DisplayRandomReflection()
    {
        int randomIndex = _random.Next(_reflections.Count);
        Console.WriteLine(_reflections[randomIndex]);
    }

    public void DisplayRandomQuestions()
    {
        int randomIndex = _random.Next(_questions.Count);
        Console.WriteLine(_questions[randomIndex]);
    }

    
}
