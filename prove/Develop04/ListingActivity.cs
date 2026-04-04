using System;
using System.Globalization;

public class ListingActivity
{
    public void Start()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.WriteLine("Get ready");
        for (int i = 1; i <= 3; i++)
        {
            
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }

        DateTime currentTime = DateTime.Now;

        int count = 0;
        
        while (currentTime < futureTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            
            count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"congratulations! You listed {count} items!");
    }
}