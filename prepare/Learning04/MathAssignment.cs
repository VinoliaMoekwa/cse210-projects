using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public  MathAssignment(string studentName, string topic, string textbookSection, string problems) 
    :base(studentName,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
