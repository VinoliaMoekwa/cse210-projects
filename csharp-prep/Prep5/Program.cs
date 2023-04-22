using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = GetUserName();
        int userNumber =GetUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DispalyResult(userName,squaredNumber);
        }
            static void DisplayWelcomeMessage()
        {
        Console.WriteLine("Welcome to the program!");
    }
    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int GetUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());

        return number ;
    }

    static int SquaredNumber(int number)
    {
        int sqaure = number * number;
        return sqaure;
    }

    static void DispalyResult(string name, int sqaure)
    {
        Console.WriteLine($"{name}, the square of your number is {sqaure}");

    }
}