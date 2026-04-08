using System;

public abstract class Goal
{
    string _name;
    string _description;
    int _scorevalue;
    public Goal(string n,string d, int s)
    {
        _name=n;
        _description=d;
        _scorevalue=s;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _scorevalue;
    }
    public abstract string Display();
    public abstract string GetStringRepresentation();
    public abstract int CompleteGoal();
}