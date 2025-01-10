using System;

class Program
{
    static void Main(string[] args)
    {
        // Displays a welcome message.
       DisplayWelcomeMessage();

        // Prompts the user for their name.
        string userName = PromptUserName();

        // Prompts the user for their favorite number.
        int userNumber = PromptUserNumber();

        // Calculates the square of the favorite number.
        int squaredNumber = SquareNumber(userNumber);

        // Displays the final message with the user's name and the squared number.
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}