using System;

class Program
{
    static void Main()
    {
        // Define the number of lines
        int numberOfLines = 5;

        // Generate the pattern
        for (int i = 1; i <= numberOfLines; i++)
        {
            // Print asterisks for the current line
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            // Move to the next line
            Console.WriteLine();
        }
    }
}
