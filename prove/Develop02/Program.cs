using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Program
    {
        private static Journal journal = new Journal();

        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Add a new entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Save journal to a file");
                Console.WriteLine("4. Load journal from a file");
                Console.WriteLine("5. Quit");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                }

                switch (choice)
                {
                    case 1:
                        AddEntry();
                        break;
                    case 2:
                        DisplayEntries();
                        break;
                    case 3:
                        SaveJournal();
                        break;
                    case 4:
                        LoadJournal();
                        break;
                    case 5:
                        return;
                }
            }
        }

        public  static void AddEntry()
        {
            var prompt = journal.GetRandomprompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write($"Response:{Response } ");
            var response = Console.ReadLine();
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            var entry = new Entry { Date = date, Prompt = prompt, Response = response };
            journal.AddEntry(entry);
            Console.WriteLine("Entry added");
        }

        private static void DisplayEntries()
        {
            journal.DisplayEntries();
        }

        private static void SaveJournal()
        {
            Console.Write("Enter a filename to save the journal to: ");
            var filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }

        static void LoadJournal()
        {
            Console.Write("Enter a filename to load the journal from: ");
            var filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                var serializer = new XmlSerializer(typeof(List<Entry>));
                using (var stream = new FileStream(filename, FileMode.Open))
    
                Console.WriteLine($"Journal loaded from {filename}");
            }
            else
            {
                Console.WriteLine($"File {filename} does not exist");
            }
        }
    }






