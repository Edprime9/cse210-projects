using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal aJournal = new Journal();
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            userChoice = Console.ReadLine();


            switch (userChoice)
            {
                case "1": 
                    aJournal.AddEntry();
                    break;
                case "2": 
                    aJournal.DisplayJournal();
                    break;
                case "3": 
                    aJournal.SaveToFile();
                    break;
                case "4":
                    aJournal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }       
    }
}