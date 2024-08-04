using System;

class Program
{
    static void Main()
    {
        // Part 1: Check if a user-entered number is prime
        Console.Write("Enter a number to check if it's prime: ");
        if (int.TryParse(Console.ReadLine(), out int numberToCheck))
        {
            bool isPrime = IsPrime(numberToCheck);
            Console.WriteLine($"{numberToCheck} is {(isPrime ? "a prime" : "not a prime")} number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine(); // Add a blank line for separation

        // Part 2: Display first 25 prime numbers using while loop
        Console.WriteLine("First 25 prime numbers (using while loop):");
        DisplayFirstNPrimesUsingWhile(25);

        Console.WriteLine(); // Add a blank line for separation

        // Part 3: Display first 25 prime numbers using for loop
        Console.WriteLine("First 25 prime numbers (using for loop):");
        DisplayFirstNPrimesUsingFor(25);

        Console.WriteLine(); // Add a blank line for separation

        // Part 4: Display first 25 prime numbers using do-while loop
        Console.WriteLine("First 25 prime numbers (using do-while loop):");
        DisplayFirstNPrimesUsingDoWhile(25);
    }

    // Method to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true; // 2 is the only even prime number
        if (num % 2 == 0) return false; // Other even numbers are not prime

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0) return false;
        }

        return true;
    }

    // Method to display the first N prime numbers using a while loop
    static void DisplayFirstNPrimesUsingWhile(int count)
    {
        int primesFound = 0;
        int number = 2;

        while (primesFound < count)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                primesFound++;
            }
            number++;
        }
    }

    // Method to display the first N prime numbers using a for loop
    static void DisplayFirstNPrimesUsingFor(int count)
    {
        int primesFound = 0;
        for (int number = 2; primesFound < count; number++)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                primesFound++;
            }
        }
    }

    // Method to display the first N prime numbers using a do-while loop
    static void DisplayFirstNPrimesUsingDoWhile(int count)
    {
        int primesFound = 0;
        int number = 2;

        do
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                primesFound++;
            }
            number++;
        } while (primesFound < count);
    }
}
