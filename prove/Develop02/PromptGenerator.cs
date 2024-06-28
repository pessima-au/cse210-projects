using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }


    public string GetRandomPrompt()
    {
        if (-_prompts.Count == 0)
        {
            throw new InvalidOperationException("No prompts available.");
        }


        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}