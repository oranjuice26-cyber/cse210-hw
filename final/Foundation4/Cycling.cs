using System;

class Cycling : Activity
{
    private double _speed;
    public override double GetDistance()
    {
        return (_speed/60)*GetDuration();
    }
    public override double GetPace()
    {
        return GetDuration()/GetDistance();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public Cycling(DateOnly d, int u, double s, string n="Cycling") : base(d, u, n)
    {
        _speed=s;
    }
}