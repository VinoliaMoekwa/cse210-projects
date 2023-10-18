using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

public class Entry  //I added twith the Journal Class because it was too small to have its own program, I also couldnt find a way to add it inside the journal Class. I read that doing it like this is okay so I hope its really okay.
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
}

public class Journal
{

    public List<Entry> entries = new List<Entry>();


    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry
        {
            Date = DateTime.Now,
            Prompt = prompt,
            Response = response,
        };

        entries.Add(entry);
    }

    public void DisplayEntry()
    {
        Console.WriteLine("/n Entries:");
        foreach (var entry in entries)

            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\n Response: {entry.Response}\n");

    }

    public void LoadFromFile(string filename)
    {
        using (var reader = new StreamReader(filename))
        {
            foreach (var entry in entries)

                Console.WriteLine($"Date: {entry.Date}\nPrompt:{entry.Prompt}\n Response:{entry.Response}\n");


        }
        Console.WriteLine($"Journal loaded from  {filename}");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                string line = $"{entry.Date.ToString("yyyy-MM-dd HH:mm:ss")},{entry.Prompt}";
                writer.WriteLine(line);
            }
        }
    }

}






