using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>{};
    public Journal()
    {
        
    }
    public void addEntry(Entry e)
    {
        entries.Add(e);
    }
    public void Display()
    {
        foreach (Entry e in entries){
            e.Display();
        }
    }
}