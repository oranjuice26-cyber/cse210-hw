using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string n, string d, int u):base(n,d,u)
    {
        
    }
    public void Run()
    {
        StartMessage();
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine("Get Ready...");
        for(int i = 0; i < 5; i++)
        {
            Console.Write("\\");

            Thread.Sleep(400);

            Console.Write("\b \b"); 
            Console.Write("-"); 
            Thread.Sleep(400);

            Console.Write("\b \b"); 
            Console.Write("/"); 
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("|"); 
            Thread.Sleep(400);
            Console.Write("\b \b");
        }
        EndMessage();
        Console.Clear();
    }
}