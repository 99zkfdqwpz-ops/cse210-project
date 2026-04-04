using System;

public class ReflectingActivity
{
    public void Start()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
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

        
        while (currentTime < futureTime)
        {
            string[] prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
            Random random = new Random();
            int index = random.Next(prompts.Length);
            string prompt = prompts[index];
            Console.WriteLine(prompt);
            System.Threading.Thread.Sleep(5000);
            
            currentTime = DateTime.Now;
        }
    }
}