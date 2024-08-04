using System;

class Program
{
    static void Main()
    {
        // Prompt user for basic salary
        Console.Write("Enter the Basic Salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        // Prompt user for total sales amount
        Console.Write("Enter the Total Sales Amount: ");
        double salesAmount = Convert.ToDouble(Console.ReadLine());

        // Initialize commission percentage
        double commissionPercentage = 0.0;

        // Calculate commission percentage based on sales amount
        if (salesAmount >= 5000 && salesAmount <= 7500)
        {
            commissionPercentage = 3.0;
        }
        else if (salesAmount >= 7501 && salesAmount <= 10500)
        {
            commissionPercentage = 8.0;
        }
        else if (salesAmount >= 10501 && salesAmount <= 15000)
        {
            commissionPercentage = 11.0;
        }
        else if (salesAmount > 15000)
        {
            commissionPercentage = 15.0;
        }

        // Calculate commission earned
        double commissionEarned = (commissionPercentage / 100) * salesAmount;

        // Calculate net salary
        double netSalary = basicSalary + commissionEarned;

        // Display results
        Console.WriteLine("\nSalary Breakdown:");
        Console.WriteLine($"Basic Salary: {basicSalary:C}");
        Console.WriteLine($"Total Sales Amount: {salesAmount:C}");
        Console.WriteLine($"Commission Percentage: {commissionPercentage}%");
        Console.WriteLine($"Commission Earned: {commissionEarned:C}");
        Console.WriteLine($"Net Salary: {netSalary:C}");
    }
}
