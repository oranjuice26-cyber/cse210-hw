using System;
public class PromptGenerator
{
    public List<String> prompts = new List<String>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What have I learned that I want to remember?"
    };
    public string choosePrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);

        return prompts[number];
    } 
    public PromptGenerator()
    {
    }
}