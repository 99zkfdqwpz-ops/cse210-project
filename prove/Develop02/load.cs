using System;
using System.IO;
class Load
{    public void LoadJournal(Journal journal, string filename)
    {
        Console.WriteLine("Enter the filename to load your journal:");
        filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    if (parts.Length == 2)
                    {
                        journal.AddEntry(parts[0], parts[1]);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}