using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompts prompts = new Prompts();
        Save save = new Save();
        Load load = new Load();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts._GetPrompt();
                    Console.WriteLine(prompt);
                    string entry = Console.ReadLine();
                    journal.AddEntry(prompt, entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    save.SaveJournal(journal, "");
                    break;
                case "4":
                    load.LoadJournal(journal, "");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}