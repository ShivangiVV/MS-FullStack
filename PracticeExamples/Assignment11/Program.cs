using System;

class MaxOfThreeIfElse
{
    static void Main()
    {
        // Prompt user for three numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        // Variable to store the maximum number
        double max;

        // Determine the maximum using if-else statements
        if (num1 >= num2 && num1 >= num3)
        {
            max = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            max = num2;
        }
        else
        {
            max = num3;
        }

        // Display the maximum number
        Console.WriteLine($"The maximum number is: {max}");
    }
}
