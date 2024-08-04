using System;

class Program
{
    static void Main()
    {
        const int charactersPerPage = 10;

        for (int i = 0; i <= 255; i++)
        {
            // Print the ASCII character and its decimal value
            Console.WriteLine($"Decimal: {i}, ASCII: {(char)i}");

            // Check if we need to pause
            if ((i + 1) % charactersPerPage == 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(); // Pause and wait for user input
                Console.Clear();  // Clear the console for better readability
            }
        }
    }
}
