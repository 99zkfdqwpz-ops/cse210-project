using System;

class Program
{
    static void Main(string[] args)
    {
    
      Console.WriteLine("menu options:");
      Console.WriteLine("1. start breathing activity");
      Console.WriteLine("2. start reflecting activity");
      Console.WriteLine("3. start listing activity");
      Console.WriteLine("4. quit");
      Console.Write("select a choice from the menu: ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Start();
        }
        else if (choice == "2")
        {
           ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.Start();
        }
        else if (choice == "3")
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Start();
        }
         else if (choice == "4")
        {
            Console.WriteLine("goodbye");
        }
         else
        {
            Console.WriteLine("invalid choice");
        }
    }
}