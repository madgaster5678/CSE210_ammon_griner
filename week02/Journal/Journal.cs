using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
    public List<Entry> _entry = new List<Entry>();
    
    
    public void AddEntry (Entry entry)
    {
        _entry.Add(entry);
    }

    public void JournalDisplay()
    {
        foreach (Entry journalEntry in _entry)
        {
            Console.WriteLine($"{journalEntry._date}| Prompt: {journalEntry._prompt}| Response: {journalEntry._response}| Mood: {journalEntry._mood}");
        }
    }

    public void SaveAsFile(string journalFile)
    {
       using (StreamWriter writer = new StreamWriter(journalFile))
        {
            foreach (Entry journalEntry in _entry)
        {
            writer.WriteLine($"{journalEntry._date}|{journalEntry._prompt}|{journalEntry._response}|{journalEntry._mood}");
        }
        }
    }

    public void LoadFile(string journalFile)
    {
        _entry.Clear();
         using (StreamReader reader = new StreamReader(journalFile))
        {
            
           string line = reader.ReadLine();

           while (line != null)
            {
                
                string[] parts = line.Split('|');
                string comDate = parts[0];
                string comPrompt = parts[1];
                string comResponse = parts[2];
                string comMood = parts[3];
                Entry journalEntry = new Entry(comDate, comPrompt, comResponse, comMood);
                AddEntry(journalEntry);
                line = reader.ReadLine();
            } 
        }
    }
}