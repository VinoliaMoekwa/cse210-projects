using System;
using System.Security.Cryptography.X509Certificates;

public class EternalGoal :Goal
{
    

public EternalGoal(string name, int points, string description) :base(name,points,description)
{ 
  

}

public override void RecordEvent()
{
  base.RecordEvent();
}






}