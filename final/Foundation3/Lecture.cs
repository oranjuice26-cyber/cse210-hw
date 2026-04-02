using System;

class Lecture : Event
{
    private string _name;
    private int _capacity;
    public Lecture(string t, string d, DateOnly o, TimeOnly i, Address a,  string n, int c, string y="Lecture"): base(t, d, o, i, a,y)
    {
        _name=n;
        _capacity=c;
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Speaker Name: {_name}\nCapacity: {_capacity}");        
    }
}