using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string t, string d, DateOnly o, TimeOnly i, Address a,  string w, string y="Reception"): base(t, d, o, i, a,y)
    {
        _weather=w;
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Weather: {_weather}");        
    }
}