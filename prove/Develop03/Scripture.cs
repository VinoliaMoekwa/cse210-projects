using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Scripture
{
    private ScriptureReference reference;
    private List<Word> _words = new List<Word>();
    private int hiddenWordCount;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        string[] textWords = text.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in textWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {reference.GetReference()}");
        foreach (var word in _words)
        {
            if (word.GetisHidden())
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write(word.GetWord() + " ");
            }
        }
        Console.WriteLine("\n\nPress Enter to continue, or type 'quit' to exit.");
    }

    public void HideRandomWord()
    {
        if (hiddenWordCount < _words.Count)
        {
            Random random = new Random();
            int randomIndex;
            do
            {
                randomIndex = random.Next(_words.Count);
            } while (_words[randomIndex].GetisHidden());
            _words[randomIndex].Hide();
            hiddenWordCount++;
        }
    }

    public int GetHiddenWordCount()
    {
        return hiddenWordCount;
    }

    public int GetWordCount()
    {
        return _words.Count;
    }

}





