using System;
using System.IO;
class Save
{
    public void SaveJournal(Journal journal, string filename)
    {   
        Console.WriteLine("Enter the filename to save your journal:");
        filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (string entry in journal._entries)
            {
                writer.WriteLine(entry);
            }
        }
    }
}