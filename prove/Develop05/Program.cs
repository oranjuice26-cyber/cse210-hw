using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        int choice = 0;
        Console.Clear();
        while(choice != 6)
        {

            Console.WriteLine($"You have {gm.GetPoints()} points.\n");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                gm.CreateGoal();
            }
            if(choice == 2)
            {
                gm.ListGoals();
            }
            if(choice == 3)
            {
                gm.SaveGoals();
            }
            if(choice == 4)
            {
                gm.LoadGoals();
            }
            if(choice == 5)
            {
                gm.RecordEvent();
            }
        }

    }
}