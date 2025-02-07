using System;

class BreathingActivity : Activity
{
    
    /* BreathingActivity() is a special method 
    called a constructor that is used to
     initialize objects */
    public BreathingActivity() : base("Breathing Activity", "Focus on your breathing to relax.", 15) {}
    
    public override void Run()
    {
       DisplayStartingMessage(); //Displays a starting message
        for (int i = 0; i < _duration / 3; i++)
        {
            Console.WriteLine("Breathe in..."); //Prompts the user to inhale.
            ShowCountDown(3); //Displays Counts down
            Console.WriteLine("Breathe out..."); // Prompts the user to exhale.
            ShowCountDown(3);
    }
    DisplayEndingMessage();
    }
}