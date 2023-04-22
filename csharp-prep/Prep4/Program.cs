using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
    
        
    int userChoice = -1;
    while( userChoice != 0)
    {
        Console.Write("Enter number, enter 0 to quit: ");

        string userInput = Console.ReadLine();
        userChoice = int.Parse(userInput);
    

        if (userChoice != 0)
        {
            numbers.Add(userChoice);
        }
    }
     
     int sum = 0;
     foreach(int number in numbers)
     {
        sum += number;
     }

     Console.WriteLine($"The sum is:{sum}");

     float average = ((float)sum)/numbers.Count;
     Console.WriteLine($"The average is:{average}");

    int max = numbers[0];

    foreach(int number in numbers)
    {
        if (number> max)
        {
            max = number;
        }

    }
    Console.WriteLine($"The max is:{max}");
        }

    }
