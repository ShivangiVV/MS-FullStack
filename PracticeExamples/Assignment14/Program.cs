using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");

        // Read the user input and convert it to a double
        string input = Console.ReadLine();
        double number;

        // Check if the input is a valid number
        if (double.TryParse(input, out number))
        {
            // Find the absolute value of the number
            double absoluteValue = Math.Abs(number);

            // Display the result
            Console.WriteLine("The absolute value of {0} is {1}.", number, absoluteValue);
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
