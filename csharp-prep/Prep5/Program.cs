using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromtUserNumber();

        int sqauredNumber = SqaureNumber(userNumber);

        DisplayResults(  name, square);
    }



        static void DisplayWelcomeMessage(){
            Console.WriteLine("Welcome to the program!");

        }

        static  string PromptUserName()
        {
            Console.Write("What is your name?");
            string name =Console.ReadLine();

            return name;
            
        }

        static int PromtUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number =int.Parse(Console.ReadLine());

            return number;
        }
 
        static int SqaureNumber (int number)
        {
            int sqaure = number * number;
            return sqaure;
        }

        static void DisplayResults( string name, int sqaure)
        {
            Console.WriteLine($"{name} ,the sqaure of your number is {sqaure}");
        }

    }
