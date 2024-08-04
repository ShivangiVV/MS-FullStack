using System;

class DateDetails
{
    static void Main()
    {
        // Prompt user to enter the date in dd/mm/yy format
        Console.Write("Enter the date (dd/mm/yy): ");
        string inputDate = Console.ReadLine();

        // Split the input string into day, month, and year
        string[] dateParts = inputDate.Split('/');

        // Validate input length
        if (dateParts.Length != 3)
        {
            Console.WriteLine("Invalid date format. Please enter date in dd/mm/yy format.");
            return;
        }

        // Parse the input date
        int day, month, year;

        if (!int.TryParse(dateParts[0], out day) ||
            !int.TryParse(dateParts[1], out month) ||
            !int.TryParse(dateParts[2], out year))
        {
            Console.WriteLine("Invalid date values. Please enter numeric values.");
            return;
        }

        // Check for valid month and year range
        if (month < 1 || month > 12 || year < 0)
        {
            Console.WriteLine("Invalid month or year value. Please enter valid values.");
            return;
        }

        // Create a DateTime object
        DateTime date = new DateTime(year + 2000, month, day);

        // Get the number of days in the month
        int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

        // Get the month name
        string monthName = date.ToString("MMMM");

        // Print the results
        Console.WriteLine($"\nMonth: {monthName}");
        Console.WriteLine($"Total number of days in the month: {daysInMonth}");
    }
}
