using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        BreathingActivity b = new BreathingActivity("Breathing Activity","relax by focusing on your breathing and walking you through deep breaths. Clear your mind and focus on your breathing.",0);
        while(choice!=4){
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice=int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                b.Run();
                
            }else if (choice == 2)
            {
                Console.WriteLine("reflect");
            }else if (choice == 3)
            {
                Console.WriteLine("listong");
            }else if (choice == 4)
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Not an option");
            }
        }
        
        

    }
}