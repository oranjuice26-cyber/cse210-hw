using System;

public class SimpleGoal: Goal
{
    private bool _completed=false;
    public SimpleGoal(string n, string d, int p, bool b) : base(n, d, p)
    {
        _completed=b;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_completed}";
    }
    public override string Display()
    {
        if (_completed)
        {
            return $"[X] {GetName()} ({GetDescription()})";
        }
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        _completed=true;
        return GetPoints();
    }
}