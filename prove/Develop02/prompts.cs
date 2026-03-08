using System;
using System.Security.Cryptography.X509Certificates;

public class Prompts
{
    public string _GetPrompt()
    {
        string[] _prompts = 
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "Describe a challenge you faced and how you overcame it.",
            "What is something new you learned recently?",
            "Write about a person who inspires you and why.",
            "did you meet someone new today? If so, describe them and your interaction.",
            "What is a goal you have for the next week and how do you plan to achieve it?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
     
    }

    //save the prompts to desplay in the journal entries
    public void SavePrompt(string prompt)
    {
        using (StreamWriter writer = new StreamWriter("prompts.txt", true))
        {
            writer.WriteLine(prompt);
        }
    }

}