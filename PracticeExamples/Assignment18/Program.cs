using System;

class Program
{
    static void Main()
    {
        // Loop through all combinations of 1, 2, and 3
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    // Print the combination
                    Console.WriteLine($"{i} {j} {k}");
                }
            }
        }
    }
}
