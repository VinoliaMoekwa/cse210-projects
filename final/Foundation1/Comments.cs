using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Comments{

private string _name;
private string _text;

public string GetName()
{
    return _name;
}
    
public string GetText()
{
    return _text;

}

public Comments( string name, string text)
{
    _name = name;
    _text = text;
}

}