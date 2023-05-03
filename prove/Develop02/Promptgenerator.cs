using System;


public class PromptGenerator {
    private string[] prompts = new string[] {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What do I plan to work on tomorrow?",
        "Who made me smile the most today?"
    };

   public Random rand =new Random ();

   public string GetRandomprompt()
   {
    return prompts[rand.Next(prompts.Length)];
   }

    
}