
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public PromptGenerator()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What did I learn today? ");
        _prompts.Add("How did I see The Lord's hand today? ");
        _prompts.Add("In one word, how could I describe my day? ");
        _prompts.Add("What did I do today to become a better person? ");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0, _prompts.Count);
        return _prompts[number];

    }
}