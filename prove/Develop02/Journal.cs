using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

public class Entry  //I added twith the Journal Class because it was too small to have its own program, I also couldnt find a way to add it inside the journal Class. I read that doing it like this is okay so I hope its really okay.
{
    public DateTime _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }
}

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(string prompt, string response)
    {
        Entry _entry = new Entry
        {
            _date = DateTime.Now,
            _prompt = prompt,
            _response = response,
        };

        _entries.Add(_entry);
    }
    public void DisplayEntry()
    {
        Console.WriteLine("/n Entries:");
        foreach (var entry in _entries)

            Console.WriteLine($"Date: {entry._date}\nPrompt: {entry._prompt}\n Response: {entry._response}\n");

    }

    public void LoadFromFile(string _filename)
    {
        _entries.Clear();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                Entry entry = new Entry();
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    entry._date = DateTime.Parse(parts[0]);
                    entry._prompt = parts[1];
                    entry._response = parts[2];
                    _entries.Add(entry);

                    Console.WriteLine($"Date: {entry._date}\nPrompt: {entry._prompt}\n Response: {entry._response}\n");

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
    public void SaveToFile(string _filename)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
    }

}






