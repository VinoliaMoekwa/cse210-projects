using System;
using System.Dynamic;

public class PromptGenerator
{
    //Instead of a list I used an array, I learnedh how to make one on C# from a video but I do not remember the vlogger.
    string[] _prompts = new string[] {
        "What did I enjoy the most about my day today?",
        "What would I do over today if I had the chance? ",
        "How did I see the hand of the Lord in my day today?",
        "Who did I help today?",
        "What was my overall mood today?",
        "Who helped me today? ",
        "What will I do better tommorrow?",

    };

    Random _rand = new Random();
    public string GetRandomPrompt() // I spent a lot of time on this one because I was confused on how a string suddenly acts like a method. After some reading, I kind of get it. This was the most widely used method to get randomprompt, if there is an easier way I would like to know it. 
    {
        int randomIndex = _rand.Next(0, _prompts.Length);

        string getRandomPrompt = _prompts[randomIndex];
        return getRandomPrompt;
    }
}









