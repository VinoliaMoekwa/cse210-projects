using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var reference = new ScriptureReference("Mosiah", 5, 2);
        var text = "And they all cried with one voice, saying: Yea, we believe all the words which thou hast spoken unto us; and also, we know of their surety and truth, because of the Spirit of the Lord Omnipotent, which has wrought a mighty achange in us, or in our hearts, that we have no more disposition to do bevil, but to do good continually.";

        var scripture = new Scripture(reference, text);

        bool quitRequested = false;

        while (scripture.GetHiddenWordCount() < scripture.GetWordCount() && !quitRequested)

        {
            scripture.Display();
            string userInput = Console.ReadLine();

            if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                quitRequested = true;
            }
            else
            {
                scripture.HideRandomWord();
            }
        }

        if (quitRequested)
        {
            Console.WriteLine("You have requested to quit.");
        }
        else
        {
            Console.WriteLine("No more words to hide, good job!.");
        }
    }
}
