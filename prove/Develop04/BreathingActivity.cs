using System; 

class BreathingActivity
{
    public void Start()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

       Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin...");
        System.Threading.Thread.Sleep(2000);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(4000);
        }
        Console.WriteLine($"Well done! You have completed the Breathing Activity. ({duration} seconds)");

    }
}