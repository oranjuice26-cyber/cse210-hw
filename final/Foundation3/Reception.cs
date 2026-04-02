using System;

class Reception : Event
{
    private string _email;

    public Reception(string t, string d, DateOnly o, TimeOnly i, Address a,  string e, string y="Reception"): base(t, d, o, i, a,y)
    {
        _email=e;
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"RSVP Here: {_email}");        
    }
}