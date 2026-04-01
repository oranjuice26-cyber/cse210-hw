using System;

class Comment
{
    private string _name;
    private string _text;

    public void Display()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
    public Comment(string n, string t)
    {
        _name=n;
        _text=t;
    }
}