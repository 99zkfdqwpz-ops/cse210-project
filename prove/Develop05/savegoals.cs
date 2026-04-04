using System;
using System.IO;
using System.Collections.Generic;

public class GoalManagement
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManagement()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetGoalType()} {_goals[i].GetName()} - {_goals[i].GetDescription()}");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            
            _totalPoints += goal.GetPoints();
            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _totalPoints += checklist.GetBonusPoints();
            }
            
        }
    }

    public int GetTotalPoints() => _totalPoints;

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _totalPoints = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string goalType = parts[1];
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                bool isComplete = bool.Parse(parts[5]);

                if (type == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(goalType, name, description, points);
                    if (isComplete) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal goal = new EternalGoal(goalType, name, description, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    int targetCount = int.Parse(parts[6]);
                    int currentCount = int.Parse(parts[7]);
                    int bonusPoints = int.Parse(parts[8]);
                    ChecklistGoal goal = new ChecklistGoal(goalType, name, description, points, targetCount, bonusPoints);
                    for (int j = 0; j < currentCount; j++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
                
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}