using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think about a time you overcame a challenge.", "Think about a moment of kindness you experienced." };
    private List<string> _questions = new List<string> { "How did you feel?", "What did you learn?", "How has this affected you?" };

    public ReflectingActivity() : base("Reflecting Activity", "Reflect on past experiences with guiding questions.", 10) {}

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
        }
    }
}