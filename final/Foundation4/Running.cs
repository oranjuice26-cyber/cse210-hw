using System;

class Running : Activity
{
    private double _distance;

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return GetDuration()/_distance;
    }
    public override double GetSpeed()
    {
        return (_distance/GetDuration())*60;
    }
    public Running(DateOnly d, int u, double i, string n="Running") : base(d,u,n)
    {
        _distance=i;
    }
}