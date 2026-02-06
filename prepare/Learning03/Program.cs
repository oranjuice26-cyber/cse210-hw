using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Random random = new Random();
        for(int i=0; i<20; i++)
        {
            int t = random.Next(1,11);
            int b = random.Next(1,11);
            a.setTop(t);
            a.setBottom(b);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {a.GetFractionString()}");
            Console.WriteLine($" Number: {a.GetDecimalValue()}");            
        }
    }
}