using System;
using System.Security;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        /*
        List<int> numbers = new List<int>();
        List<string> words = new List<string>(); 
        */  

        /* 
        Creates a dynamic list to store integers, and
        hold all numbers entered by the user (excluding 0, which ends the input).
         */
        List<int> numbers = new List<int>(); 

        
        // Please note we could use a do-while loop here instead

        // Initializes the variable to enter the while loop.
        int userNumber = -1;

        //Continues looping until the user enters 0.
        while (userNumber != 0)

        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();

            // Converts the string input to an integer.
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;

        // Iterates through each number in the list.
        foreach (int number in numbers)
        {
            // Adds the current number to the sum.
            sum += number;
        }

        // The total sum of all entered numbers is displayed.
        Console.WriteLine($"The sum is: {sum}");

        //((float)sum): Casts the sum to a float to avoid integer division.
        // numbers.Count: Returns the total number of elements in the list.
        // The average is calculated by dividing the sum by the count and displayed.

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numbers[0];

        // Iterates through each number in the list.
        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}