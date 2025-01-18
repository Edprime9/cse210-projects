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

        
        }
    }
}