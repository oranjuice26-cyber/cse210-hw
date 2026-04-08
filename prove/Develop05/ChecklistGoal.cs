using System;

public class ChecklistGoal: Goal
{
    private int _timesCompleted=0;
    private int _bonusTime;
    private int _bonusValue;
    public ChecklistGoal(string n, string d, int p,int t, int b, int c) : base(n, d, p)
    {
        _bonusTime=t;
        _bonusValue=b;
        _timesCompleted=c;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_timesCompleted},{_bonusTime},{_bonusValue}";
    }

    public override string Display()
    {
        if (_timesCompleted == _bonusTime)
        {
            return$"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_bonusTime}";
        }
        return$"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_bonusTime}";
    }
    public override int CompleteGoal()
    {
        int _totalPoints = GetPoints();
        _timesCompleted=_timesCompleted+1;
        if (_timesCompleted == _bonusTime)
        {
            _totalPoints=_totalPoints+_bonusValue;
        }
        Console.WriteLine($"Congratulations! You have earned {_totalPoints} points!");

        return _totalPoints;
    }
}