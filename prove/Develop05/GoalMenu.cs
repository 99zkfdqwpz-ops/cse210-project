using System;

public class GoalMenu
{
    public int GoalChoice()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Exit");
        Console.Write("Which type of goal would you like to create? ");
        return int.Parse(Console.ReadLine());
    }
}