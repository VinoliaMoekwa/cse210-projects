using System;

public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    public ScriptureReference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseStart; // Initialize verseEnd to verseStart by default
    }
    public ScriptureReference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public string GetReference()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}

