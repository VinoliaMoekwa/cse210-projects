using System;
using System.Reflection.Metadata;
using System.Transactions;
using System.Xml.Linq;
using System.Xml.Serialization;

//Save inside a cvs

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.GetRandomPrompt();

        Journal journal = new Journal();

        string option = "0";
        do
        {
            Console.WriteLine("Please select an option below: ");
            Console.WriteLine("1.Add entry");
            Console.WriteLine("2.Display entry");
            Console.WriteLine("3.Load from file");
            Console.WriteLine("4.Save to file");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do?");

            option =Console.ReadLine();

            if (option == "1")
            {
                
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Random Prompt:");
                Console.WriteLine(prompt);
                Console.Write("Enter your response: ");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);

                };
        

            
            if (option == "2")
            {
                journal.DisplayEntry();
            }

            if (option == "3")
            {   Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

            }
            
            if (option == "4")
            { 
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }

            while (option != "5");
        }
    

        
    }


