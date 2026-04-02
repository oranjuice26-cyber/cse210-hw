using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly d = new DateOnly(2026, 4, 2);
        Running r = new Running(d,60,7);
        Cycling c = new Cycling(d,90,15);
        Swimming s = new Swimming(d,30,30);
        List<Activity> a = new List<Activity>
        {
            r,c,s
        };
        Console.Clear();
        foreach(Activity b in a)
        {
            Console.WriteLine(b.GetSummary());
        }
    }
}