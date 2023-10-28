using System;
using System.Collections.Generic;
public class Word
{
    private string _word;
    private bool isHidden;

    public Word(string _word)
    {
        this._word = _word;
        isHidden = false;
    }
    public bool GetisHidden()
    {
        return isHidden;
    }
    public string GetWord()
    {
        return _word;
    }
    public void Hide()
    {
        isHidden = true;
    }
}



