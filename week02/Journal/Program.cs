using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");

        Console.Write("Enter selecton: ");
        string userInput = Console.ReadLine();

        Console.WriteLine($"User Selected {userInput}");

        if (userInput == "1")
        {
            Console.WriteLine("Write new entry");
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Display Journal");
        }
        else if (userInput == "3")
        {
            Console.WriteLine("Save Journal");
        }
        else if (userInput == "4")
        {
            Console.WriteLine("Load Journal");
        }
        else if (userInput == "5")
        {
            return;
        }
        else
        {
            Console.WriteLine("Please try again");
        }
        }
    }
}