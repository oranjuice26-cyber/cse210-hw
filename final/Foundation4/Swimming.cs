using System;

class Swimming : Activity
{
    private int _laps;
    public override double GetDistance()
    {
        return _laps*(50.0/1000.0)*0.62;
    }
    public override double GetPace()
    {
        return GetDuration()/GetDistance();
    }
    public override double GetSpeed()
    {
        return (GetDistance()/GetDuration())*60;
    }
    public Swimming(DateOnly d, int u, int l, string n="Swimming") : base(d, u, n)
    {
        _laps=l;
    }
}