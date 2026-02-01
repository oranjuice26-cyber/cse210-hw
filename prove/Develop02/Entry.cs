using System;
public class Entry
{

    public string prompt="";
    public string date="";
    public string content="";
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine($"{content}");
    }
    public Entry(string p, string d, string c )
    {
        prompt = p;
        date = d;
        content = c;
    }
}