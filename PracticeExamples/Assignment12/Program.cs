using System;

class EmployeeDetails
{
    static void Main()
    {
        // Prompt user for Employee number
        Console.Write("Enter Employee number: ");
        int employeeNo = Convert.ToInt32(Console.ReadLine());

        // Prompt user for Department number
        Console.Write("Enter Department number: ");
        int departmentNo = Convert.ToInt32(Console.ReadLine());

        // Prompt user for Designation code
        Console.Write("Enter Designation code: ");
        char designationCode = Convert.ToChar(Console.ReadLine());

        // Variables to store Department name and Designation
        string departmentName = "";
        string designation = "";

        // Determine Department name and Designation based on input
        switch (departmentNo)
        {
            case 10:
                departmentName = "Purchase";
                break;
            case 20:
                departmentName = "Sales";
                break;
            case 30:
                departmentName = "Production";
                break;
            case 40:
                departmentName = "Marketing";
                break;
            case 50:
                departmentName = "Accounts";
                break;
            default:
                departmentName = "Unknown";
                break;
        }

        switch (designationCode)
        {
            case 'M':
                designation = "Manager";
                break;
            case 'S':
                designation = "Supervisor";
                break;
            case 'A':
                designation = "Analyst";
                break;
            case 's':
                designation = "Sales Person";
                break;
            case 'a':
                designation = "Accountant";
                break;
            default:
                designation = "Unknown";
                break;
        }

        // Display the entered data with proper messages
        Console.WriteLine("\nEntered Employee Details:");
        Console.WriteLine($"Employee Number: {employeeNo}");
        Console.WriteLine($"Department Number: {departmentNo}");
        Console.WriteLine($"Department Name: {departmentName}");
        Console.WriteLine($"Designation Code: {designationCode}");
        Console.WriteLine($"Designation: {designation}");
    }
}
