using System;

public class EternalGoal: Goal
{
    public EternalGoal(string n, string d, int p) : base(n, d, p)
    {
        
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
    public override string Display()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return GetPoints();
    }
}