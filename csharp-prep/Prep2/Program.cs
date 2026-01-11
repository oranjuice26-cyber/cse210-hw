using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);
        string letterGrade = "";
        if (grade < 60)
        {
            letterGrade = "F";
        } 
        else if (grade < 70)
        {
            letterGrade = "D";
        }
        else if (grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade < 90)
        {
            letterGrade = "B";
        }
        else
        {
            letterGrade = "A";
        }
        Console.WriteLine(letterGrade);
        if (grade >= 70)
        {
            Console.Write("You passed! Good Job!");
        }
        else
        {
            Console.Write("You did not pass. I am sure you will next time!");
        }
    }
}