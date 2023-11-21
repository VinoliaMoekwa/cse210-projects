using System;
using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal 
{



public SimpleGoal(string name, int points, string description ) :base(name, points,description)
{
}
    
public override void RecordEvent()
{
 base.RecordEvent();

}

}




