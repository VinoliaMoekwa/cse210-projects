using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"You have  points.");
        Goal goal = new Goal("",0,"");
        string option = "0";
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");

             option = Console.ReadLine();

            if (option == "1")
            {
             
             goal.CreateGoal();

            };

            if (option == "2" )
            {
                goal.ListGoals();
            };

            if (option == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string _filename = Console.ReadLine();
                goal.SaveGoals(_filename);
            };

            if (option =="4")
            {
                Console.Write("Enter the filename to load from: ");
                string _filename = Console.ReadLine();
                goal.LoadGoals(_filename);
            };

            if (option =="5"){
                goal.RecordEvent();
            }
        }
        while (option != "6" );
    }
}






