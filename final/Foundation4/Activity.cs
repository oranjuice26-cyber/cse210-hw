using System;

class Activity
{
    private DateOnly _date;
    private int _duration;
    private string _name;
    public int GetDuration()
    {
        return _duration;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} {_name} ({_duration} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
    public Activity(DateOnly d, int u, string n)
    {
        _date=d;
        _duration=u;
        _name=n;
    }
}