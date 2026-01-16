using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string uName = PromptUserName();
        int uNumber = PromptUserNumber();
        int squareNum = SquareNumber(uNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(uName, squareNum, birthYear);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("Please enter the year you were born: ");
        birthYear=int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int s = number*number;
        return s;
    }
    static void DisplayResult(string n, int s, int b)
    {
        Console.WriteLine($"{n}, the square of your number is {s}.");
        Console.WriteLine($"{n}, you will turn {2026-b} years old this year.");
    }
}