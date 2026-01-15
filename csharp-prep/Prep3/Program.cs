using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int hiddenNum = randomGenerator.Next(1,101);
        int guessInt = -1;
        while(guessInt != hiddenNum)
        {
            Console.WriteLine("Guess the number: ");
            string guessStr = Console.ReadLine();
            guessInt = int.Parse(guessStr);
            if (guessInt == hiddenNum)
            {
                Console.WriteLine("You guessed it!");
            } else if (guessInt > hiddenNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }            
        }

    }
}