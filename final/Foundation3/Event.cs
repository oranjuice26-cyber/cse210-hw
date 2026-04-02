using System;

class Event
{
    private string _title;
    private string _description;
    private DateOnly _date; 
    private TimeOnly _hour;
    private Address _address;
    private string _type;

    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_hour}\nAddress:\n{_address.FullAddress()}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"Type: {_type}\nTitle: {_title}\nDate: {_date}");
    }
    public Event(string t, string d, DateOnly o, TimeOnly i, Address a,string y)
    {
        _title=t;
        _description=d;
        _date=o;
        _hour=i;
        _address=a;
        _type=y;
    }

}