using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Please enter the magic number: ");
        //string nuumber =Console.ReadLine();
        //int magicNumber = int.Parse(nuumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while(guess!= magicNumber)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

        //string level ="";

        if  (magicNumber > guess)
        {
            Console.WriteLine( "Higher");
        }

        else if  (magicNumber <guess)
        {
             Console.WriteLine("Lower");
        }
        else 
        {
            Console.WriteLine("You guessed correctly!");
            }

        //Console.WriteLine( level);

        }
    }
}