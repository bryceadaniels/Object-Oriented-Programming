using System;
using System.Collections.Generic;
public class PromptGenerator
{

    public PromptGenerator(){}
    public List<string> _prompts = new List<string>();

    public void CompilePrompts()
    {
    _prompts.Add("Who was the most interesting person I met today? ");
    _prompts.Add("How did I help someone today? ");
    _prompts.Add("What made me smile today? ");
    _prompts.Add("What made me laugh today? ");
    _prompts.Add("How did I see the hand of the Lord in your life today? ");
    _prompts.Add("What was the strongest emotion I felt today? Why? ");
    }
    public string GetPrompt()
    {
        CompilePrompts();
        Random random = new Random();
        int num = random.Next(0,_prompts.Count);
        string givenPrompt = _prompts[num];
        return givenPrompt;
    }
    
}