using System;
using System.ComponentModel;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    private string _name;
    private int _points;

    private string _description;
    private int _timesCompleted;
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
        _timesCompleted = 0;

    }
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _name = description;
    }
    public int GetPoints()
    {
        return _points;

    }

    public void SetPoints(int points)
    {
        _points = points;
    }



    public void CompleteGoal()
    {
        _timesCompleted++;
    }

    public bool IsComplete()
    {
        return _timesCompleted > 0;
    }

    public void CreateGoal()
    {
        string option;
        do
        {
            Console.WriteLine("Types of goals there are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Checklist Goal");
            Console.WriteLine("3. Eternal Goal");
            Console.WriteLine("4. Enter q to quit");

            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Enter name for the Simple Goal:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a description for your Goal:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter points for Simple Goal:");
                int points;
                int.TryParse(Console.ReadLine(), out points);
                AddGoal(new SimpleGoal(name, points, description));

            }
            else if (option == "2")
            {
                Console.WriteLine("Enter name for Checklist Goal:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a description for your Goal:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter target count for Checklist Goal:");
                int requiredTimes;
                int.TryParse(Console.ReadLine(), out requiredTimes);
                Console.WriteLine("How many times has it been completed?");
                int timesCompleted;
                int.TryParse(Console.ReadLine(), out timesCompleted);
                Console.WriteLine("Enter points per completion for Checklist Goal:");
                int points;
                int.TryParse(Console.ReadLine(), out points);
                Console.WriteLine("Enter bonus points for Checklist Goal:");
                int bonusPoints;
                int.TryParse(Console.ReadLine(), out bonusPoints);
                AddGoal(new ChecklistGoal(name, points, requiredTimes, bonusPoints, description, timesCompleted));
                Console.WriteLine($"{timesCompleted} times / {requiredTimes} required times.");
            }
            else if (option == "3")
            {
                Console.WriteLine("Enter name for Eternal Goal:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a description for your Goal:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter points for Eternal Goal:");
                int points;
                int.TryParse(Console.ReadLine(), out points);

                AddGoal(new EternalGoal(name, points, description));
            }

        } while (option != "q");
    }

    public void ListGoals()
    {
        Console.Write("The goals are:");
        foreach (var goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "✔" : "[]"; // Checkmark or empty bracket based on completion status
            Console.WriteLine($"Status: {completionStatus} ,Name: {goal._name}, Description: {goal._description}, Points: {goal._points}");
        }
    }

    public void SaveGoals(string _filename)
    {
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine($"{goal._name},{goal._description},{goal._points}");
                }
            }
        }

    }

    public void LoadGoals(string _filename)
    {
        _goals.Clear();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = 0;
                    if (int.TryParse(parts[2], out points))
                    {
                        Goal goal = new Goal(name, points, description);
                        _goals.Add(goal);

                        Console.WriteLine($"Name of the goal: {goal._name}, Description: {goal._description}, Points: {goal._points}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid points format.");
                    }
                }
                else
                {
                    Console.WriteLine("Line does not have enough fields to load the file");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file you have entered was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

public virtual void RecordEvent()
{
    int totalPoints = 0;

    Console.WriteLine("Select the goal type to record an event (Enter q to quit):");
    string option;

    do
    {
        Console.WriteLine("Types of goals available:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("4. Enter q to quit");

        option = Console.ReadLine();

        switch (option)
        {
            case "1":
                {
                    foreach (Goal goal in _goals)
                    {
                        if (goal is SimpleGoal)
                        {
                            goal.CompleteGoal();
                            totalPoints += goal.GetPoints();
                        }
                    }
                    break;
                }

            case "2":
                {
                    foreach (Goal goal in _goals)
                    {
                        if (goal is ChecklistGoal)
                        {
                            ChecklistGoal checklistGoal = goal as ChecklistGoal;
                            checklistGoal.CompleteGoal();
                            totalPoints += checklistGoal.GetPoints();

                            if (checklistGoal.IsComplete())
                            {
                                totalPoints += checklistGoal.GetBonusPoints();
                                Console.WriteLine($"You have completed the checklist goal and earned bonus points!");
                            }
                        }
                    }
                    break;
                }

            case "3":
                {
                    Console.WriteLine("Recording event for EternalGoal");
                    CompleteGoal();
                    totalPoints += GetPoints();
                    break;
                }

            case "q":
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }

        if (option != "q")
        {
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points for the selected goal type.");
        }
    } while (option != "q");
}
}


    