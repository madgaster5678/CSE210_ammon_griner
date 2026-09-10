using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts = new List<string>();
    public PromptGenerator()
    {
        prompts.Add("What could I have done better today?");
        prompts.Add("What have I learned today?");
        prompts.Add("What made me smile today?");
        prompts.Add("Did I help anyone that needed it today?");
        prompts.Add("Did I see the lord's hand in my life today?");
    }
    
    public string GetRandomPrompt()
    {
        Random getPrompt = new Random();
        int promptNumber = getPrompt.Next(prompts.Count);
        string chosenprompt = prompts[promptNumber];
        return chosenprompt;
    }
}