using System;

class BasicCalculator
{
    static void Main()
    {
        // Variables to store user input numbers
        double num1, num2, result = 0;
        char operation;

        // Menu display
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("-----------------");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("a. Addition (+)");
        Console.WriteLine("b. Subtraction (-)");
        Console.WriteLine("c. Multiplication (*)");
        Console.WriteLine("d. Division (/)");
        Console.Write("Enter your choice: ");
        operation = Convert.ToChar(Console.ReadLine());

        // Prompt user for two numbers
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Perform calculation based on user's choice
        switch (operation)
        {
            case 'a':
            case '+':
                result = num1 + num2;
                Console.WriteLine($"The result of addition is: {result}");
                break;
            case 'b':
            case '-':
                result = num1 - num2;
                Console.WriteLine($"The result of subtraction is: {result}");
                break;
            case 'c':
            case '*':
                result = num1 * num2;
                Console.WriteLine($"The result of multiplication is: {result}");
                break;
            case 'd':
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"The result of division is: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid operation.");
                break;
        }
    }
}
