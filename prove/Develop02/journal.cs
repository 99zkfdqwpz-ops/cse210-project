using System;
using System.Collections.Generic;


class Journal
{
    public List<string> _entries;

    public Journal()
    {
        _entries = new List<string>();
    }

    public void AddEntry(string prompt, string entry)
    {
    
        _entries.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm") + " - " + "prompt: " + prompt + "\n" + entry);
       
    }

    public void DisplayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}