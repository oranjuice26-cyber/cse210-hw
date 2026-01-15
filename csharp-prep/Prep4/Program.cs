using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Add a number to a list, type 0 when finished.");
        int aNum = -1;
        int sum = 0;
        int large = 0;
        while(aNum != 0){
            Console.WriteLine("Enter number: ");
            aNum = int.Parse(Console.ReadLine());
            numbers.Add(aNum);
        }
        foreach(int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float mean = (float)sum / (numbers.Count-1);
        Console.WriteLine($"The average is: {mean} ");
        foreach(int number in numbers)
        {
            if (number > large)
            {
                large = number;
            }
        }
        Console.WriteLine($"The largest number is: {large}");
    }
}