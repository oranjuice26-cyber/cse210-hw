using System;

class GoalManager
{
    private int _totalPoints;
    private List<Goal> _goalList= new List<Goal>();
    public int GetPoints()
    {
        return _totalPoints;
    }
    public void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n   3.Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");
        int gchoice = int.Parse(Console.ReadLine());
        if (gchoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string n = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string d = Console.ReadLine();
            Console.Write("What is the point value of your goal? ");                
            int p = int.Parse(Console.ReadLine());
            SimpleGoal g = new SimpleGoal(n,d,p,false);
            _goalList.Add(g);
        }
        if (gchoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            string n = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string d = Console.ReadLine();
            Console.Write("What is the point value of your goal? ");                
            int p = int.Parse(Console.ReadLine());
            EternalGoal g = new EternalGoal(n,d,p);
            _goalList.Add(g);
        }
        if (gchoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            string n = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string d = Console.ReadLine();
            Console.Write("What is the point value of your goal? ");                
            int p = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplised for a bonus? ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int b = int.Parse(Console.ReadLine());
            ChecklistGoal g = new ChecklistGoal(n,d,p,t,b,0);
            _goalList.Add(g);
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        int i = 0;
        foreach(Goal g in _goalList)
        {
                i++;
                Console.WriteLine($"{i}. "+g.Display());
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach(Goal g in _goalList)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }      
        }

    }
    public void LoadGoals()
    {
        _goalList=[];
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalPoints=int.Parse(lines[0]);
        for (int i=1;i<lines.Count();i++)
        {
            string[] typeList = lines[i].Split(":");
            string type = typeList[0];
            string[] parts = typeList[1].Split(",");
            string n = $"{parts[0]}";
            string d = $"{parts[1]}";
            int p = int.Parse($"{parts[2]}");
            if(type == "EternalGoal")
            {
                EternalGoal g = new EternalGoal(n,d,p);
                _goalList.Add(g);
            }
            if (type == "SimpleGoal")
            {
                bool b = bool.Parse(parts[3]);
                SimpleGoal g = new SimpleGoal(n,d,p,b);
                _goalList.Add(g);
            }
            if (type == "ChecklistGoal")
            {
                int c = int.Parse(parts[3]);
                int b = int.Parse(parts[4]);
                int v = int.Parse(parts[5]);
                ChecklistGoal g =new ChecklistGoal(n,d,p,b,v,c);
                _goalList.Add(g);
            }
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        int i=0;
        foreach(Goal g in _goalList)
        {
            i++;
            Console.WriteLine($"{i}. {g.GetName()}");
        }
        Console.Write("Which goal did you accomplish?(Number) ");
        int choice = int.Parse(Console.ReadLine())-1;
        _totalPoints=_totalPoints+_goalList[choice].CompleteGoal();
    }
}