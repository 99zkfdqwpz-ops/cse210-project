using System;

public abstract class Goal
{
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetGoalType() => _goalType;
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
    public bool IsComplete() => _isComplete;

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string GetSaveString();
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points) {}

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{_goalType}|{_name}|{_description}|{_points}|{_isComplete}";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points) {}

    public override void RecordEvent()
    {
        // Eternal goals are never complete, but we can record events
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{_goalType}|{_name}|{_description}|{_points}|{_isComplete}";
    }
}

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string goalType, string name, string description, int points, int targetCount, int bonusPoints) : base(goalType, name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
        }
    }

    public int GetBonusPoints() => _bonusPoints;
    public int GetCurrentCount() => _currentCount;
    public int GetTargetCount() => _targetCount;

    public override string GetStatus()
    {
        return _isComplete ? $"[X] Completed {_currentCount}/{_targetCount}" : $"[ ] Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_goalType}|{_name}|{_description}|{_points}|{_isComplete}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}