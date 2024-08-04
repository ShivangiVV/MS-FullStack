using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Display the menu
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            int shapeChoice = int.Parse(Console.ReadLine());

            if (shapeChoice == 4)
            {
                break; // Exit the loop if user selects 'Exit'
            }

            // Perform operations based on the shape
            switch (shapeChoice)
            {
                case 1:
                    HandleSquare();
                    break;
                case 2:
                    HandleCircle();
                    break;
                case 3:
                    HandleRectangle();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void HandleSquare()
    {
        Console.WriteLine("You selected Square.");
        Console.Write("Enter the side length of the square: ");
        double side = double.Parse(Console.ReadLine());

        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Calculate area");
        Console.WriteLine("2. Calculate perimeter");
        Console.WriteLine("3. Calculate both area and perimeter");
        Console.Write("Enter your choice (1-3): ");
        int operationChoice = int.Parse(Console.ReadLine());

        switch (operationChoice)
        {
            case 1:
                Console.WriteLine($"Area of the square: {CalculateSquareArea(side)}");
                break;
            case 2:
                Console.WriteLine($"Perimeter of the square: {CalculateSquarePerimeter(side)}");
                break;
            case 3:
                Console.WriteLine($"Area of the square: {CalculateSquareArea(side)}");
                Console.WriteLine($"Perimeter of the square: {CalculateSquarePerimeter(side)}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void HandleCircle()
    {
        Console.WriteLine("You selected Circle.");
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Calculate area");
        Console.WriteLine("2. Calculate perimeter");
        Console.WriteLine("3. Calculate both area and perimeter");
        Console.Write("Enter your choice (1-3): ");
        int operationChoice = int.Parse(Console.ReadLine());

        switch (operationChoice)
        {
            case 1:
                Console.WriteLine($"Area of the circle: {CalculateCircleArea(radius)}");
                break;
            case 2:
                Console.WriteLine($"Perimeter (Circumference) of the circle: {CalculateCirclePerimeter(radius)}");
                break;
            case 3:
                Console.WriteLine($"Area of the circle: {CalculateCircleArea(radius)}");
                Console.WriteLine($"Perimeter (Circumference) of the circle: {CalculateCirclePerimeter(radius)}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void HandleRectangle()
    {
        Console.WriteLine("You selected Rectangle.");
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Calculate area");
        Console.WriteLine("2. Calculate perimeter");
        Console.WriteLine("3. Calculate both area and perimeter");
        Console.Write("Enter your choice (1-3): ");
        int operationChoice = int.Parse(Console.ReadLine());

        switch (operationChoice)
        {
            case 1:
                Console.WriteLine($"Area of the rectangle: {CalculateRectangleArea(length, width)}");
                break;
            case 2:
                Console.WriteLine($"Perimeter of the rectangle: {CalculateRectanglePerimeter(length, width)}");
                break;
            case 3:
                Console.WriteLine($"Area of the rectangle: {CalculateRectangleArea(length, width)}");
                Console.WriteLine($"Perimeter of the rectangle: {CalculateRectanglePerimeter(length, width)}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Methods for calculating area and perimeter of a square
    static double CalculateSquareArea(double side) => side * side;
    static double CalculateSquarePerimeter(double side) => 4 * side;

    // Methods for calculating area and perimeter of a circle
    static double CalculateCircleArea(double radius) => Math.PI * radius * radius;
    static double CalculateCirclePerimeter(double radius) => 2 * Math.PI * radius;

    // Methods for calculating area and perimeter of a rectangle
    static double CalculateRectangleArea(double length, double width) => length * width;
    static double CalculateRectanglePerimeter(double length, double width) => 2 * (length + width);
}
