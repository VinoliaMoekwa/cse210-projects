using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Journal
    {
        private List<Entry> entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            
        }

        public void DisplayEntries()
        {
            Console.WriteLine("\nAll Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
            }
        }

        public void SaveToFile(string filename)
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            using (var writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, entries);
            }
            Console.WriteLine($"Journal saved to {filename}");
        }

        public void LoadFromFile(string filename)
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            using (var reader = new StreamReader(filename))
            {
                entries = (List<Entry>)serializer.Deserialize(reader);
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
    }