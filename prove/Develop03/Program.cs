using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args) 
    { 
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    

        List<Scripture> scriptures = new List<Scripture>();

        

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"));
        
        scriptures.Add(new Scripture(
            new Reference("3Nephi",27,27),"And know ye that ye shall be judges of this people,according to the judgement which I shall give unto you,which shall be just.Therefore what manner of men ought ye to be?Verily I say unto you even as I am."));
    
        scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 4,2),  
            "Therefore,O ye that embark in the service of God,see that ye serve him with allyour heart,mind and strength,that ye may stand blameless before God at the last day."));
        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"));
        
        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"));

         Random random = new Random();

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type quit:");

            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}
    
