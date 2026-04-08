using System;

class Activity
{
   private string _activityName;
   private string _activityDescription;
   private int _activityDuration;
   public Activity(string n, string d, int u)
    {
        _activityName=n;
        _activityDescription=d;
        _activityDuration=u;
    }
    public void PauseSpinner(int p)
    {
        int d = p*1000;
        
    }
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_activityDescription}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");

    }
    public void EndMessage()
    {
        Console.WriteLine("Well Done!");
    }
    public int GetDuration()
    {
        return _activityDuration;
    }
    public void SetDuration(int i)
    {
        _activityDuration=i;
    }
    public string GetRandomPrompt(List<string> l)
    {
        return "";
    }
    public void DisplayPrompt(string p)
    {
        
    }
}