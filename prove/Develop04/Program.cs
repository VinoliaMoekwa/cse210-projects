using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {

        string option = "0";
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity🧘🏽‍♀️");
            Console.WriteLine("2.Start Reflectin Activity📓");
            Console.WriteLine("3. Start Listing Acting📝");
            Console.WriteLine("4.Quit❎");
            Console.WriteLine("Select an item from the menu.");

             option = Console.ReadLine();

            if (option== "1")

        {
        BreathingActivity breathingActivity = new BreathingActivity($"Breathing Activity", "This activity will guide you through breathing exercises.",30);
        

        breathingActivity.StartBreathingActivity();
        };

        if (option == "2")
        {
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times when you've shown strength and resilience.", 30);


        reflectionActivity.RemainingDuration();
        };

        if(option == "3")
        {
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by listing them.", 30);

        listingActivity.StartListingActivity();
        }
        }

        while (option !="4");
        
    }
}