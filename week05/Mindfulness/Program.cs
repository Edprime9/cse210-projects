using System;
using System.Runtime.InteropServices;
using activity;

class Program
{
    static void Main(string[] args)
    {  List<int> count =[];
       while(true)
       {    
            
            Console.WriteLine("Welcome To Your Mindfulness");
            Console.WriteLine("===========================");
            Console.WriteLine("---------Activities--------");
            Console.WriteLine("1. Breath Activity.");
            Console.WriteLine("2. Reflecting Activuty.");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose Activity: ");
            string option =Console.ReadLine();
            

            if (option == "1" )
            { 
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Activity welcome = new Activity(name,description,0);
                Console.WriteLine();
                
                welcome.DisplayStartingMessage();
                
            
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                int duration = int.Parse(du);
                Activity activity = new Activity(name,description,duration);
               
                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(5);

                Console.WriteLine();
                BreathingActivity breathe = new BreathingActivity(name,description,duration);
                breathe.Run();
                
                Console.Clear();
                activity.DisplayEndingMessage();
                Console.WriteLine();
                count.Add(1);
            }
            
            else if (option == "2")
            {
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                
                Activity welcome = new Activity(name,description,0);
                Console.WriteLine();
                
                welcome.DisplayStartingMessage();
                
            
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                int duration = int.Parse(du);
                Activity activity = new Activity(name,description,duration);


                Console.Clear();

                ReflectingActivity reflectingActivity = new ReflectingActivity(name,description,duration);

                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(5);

                Console.WriteLine("Consider The Following Prompt");
                Console.WriteLine();
                reflectingActivity.DisplayPrompt();
                Console.WriteLine();

                Console.WriteLine("When you have something in mind, press enter to continue");
                Console.ReadLine();
                //Thread.Sleep(1000);
                //reflectingActivity.DisplayQuestions();
                //Thread.Sleep(1000);
                Console.WriteLine("Now ponder on each of the following questions as they are related to this experience."); 
                Console.Write("You may begin in:");
                reflectingActivity.ShowCountDown(5);
                
                Console.Clear();
                reflectingActivity.DisplayQuestions();
                
                Console.Clear();
                activity.DisplayEndingMessage();
                Console.WriteLine();
                count.Add(1);
                
            }
            else if (option == "3")
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Activity welcome = new Activity(name,description,0);
                Console.WriteLine();
                
                welcome.DisplayStartingMessage();
                
            
                Console.Write("Time duration for your activity in seconds: ");
                string du = Console.ReadLine();
                Console.WriteLine();
                int duration = int.Parse(du);
                Activity activity = new Activity(name,description,duration);

               
                Console.Clear();
                Console.WriteLine("Get ready....");
                activity.ShowSpinner(5);

                Console.WriteLine();

                ListingActivity listingActivity = new ListingActivity();
                Console.WriteLine("List as many responses as you can to the following prompt.");
                Console.WriteLine(listingActivity.GetRandomPrompt());
                Console.WriteLine("You may begin in");
                listingActivity.ShowCountDown(5);               

                DateTime now = DateTime.Now;
                //Console.WriteLine(n);
                DateTime future = now.AddSeconds(duration);
                while(DateTime.Now < future)
                {
                     listingActivity.GetListFromUser();
                }

                listingActivity.Run();
                Thread.Sleep(3000);
                Console.Clear();
                activity.DisplayEndingMessage();
                Console.WriteLine();
                count.Add(1);
               
            }
            else if (option == "4")
            {
                Console.Clear();
               
                int total =0;
                foreach(int x in count)
                {
                    total=total+x;
                    //Console.WriteLine($"Total done activities {x}");
                }
                 Console.WriteLine($"Total done activities '{total}'");
                break;
                
            }

       } 
      
    
    

    }
}