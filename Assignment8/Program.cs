using System;

class LeapYearIfElse
{
    static void Main()
    {
        // Prompt user to enter a year
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Check for leap year using if-else and logical operators
        bool isLeapYear = false;

        if (year % 4 == 0)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
                isLeapYear = true;
            }
        }

        // Output the result
        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
