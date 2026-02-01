using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator p = new PromptGenerator();
        Journal j = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the folowing choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
        string choice = "";
        while(choice != "5")
        {
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                string n = p.choosePrompt();
                Console.WriteLine(n);
                Console.Write(">");
                string response = Console.ReadLine();
                Entry e = new Entry(n, DateTime.Now.ToShortDateString(), response);
                j.addEntry(e);
            }
            else if(choice == "2")
            {
                j.Display();
            }
            else if(choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                j.entries.Clear();
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    string d = parts[0];
                    string pr = parts[1];
                    string c = parts[2];
                    Entry e = new Entry(pr,d,c);
                    j.addEntry(e);
                }
            }
            else if(choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach(Entry e in j.entries)
                    {
                        outputFile.WriteLine($"{e.date}|{e.prompt}|{e.content}");
                    }
                }
            }
        }
       
        
    }
}

