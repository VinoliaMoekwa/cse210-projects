using System.Globalization;
using System;

public class Video
{
    private  string _title;
    private string _author;
    private int _length;
    private int _numberOfComments;

     public List<Comments> _comments = new List<Comments>();

public Video (string title, string author, int length, int numberOfComments)
{
    _title = title;
    _author = author;
    _length = length;
    _numberOfComments = numberOfComments;
}

public string GetTitle()
{
    return _title;
}

public string GetAuthor()
{
    return _author;
}

public int GetLength()
{
    return _length;
}

public int  GetNumberOfComments()
 {
        return _numberOfComments;
}
 
public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }


public void DisplayInfo()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Lenght:{_length} seconds");
    Console.WriteLine($"Number of Comments:{_numberOfComments}");
    Console.WriteLine($"Comments:");
    foreach (var comment in _comments)
    {
        Console.WriteLine($"Name: {comment.GetName()}, Text: {comment.GetText()}");
        }

    Console.WriteLine();
    }

}


    

