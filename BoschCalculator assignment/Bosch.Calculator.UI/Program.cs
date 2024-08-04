using System;
using Bosch.Calculator;

namespace Bosch.Calculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicMath = new BasicMath();
            var advancedMath = new AdvancedMath();

            Console.WriteLine("Basic Math Operations:");
            Console.WriteLine($"Add: 3 + 5 = {basicMath.Add(3, 5)}");
            Console.WriteLine($"Subtract: 10 - 4 = {basicMath.Subtract(10, 4)}");
            Console.WriteLine($"Multiply: 6 * 7 = {basicMath.Multiply(6, 7)}");
            Console.WriteLine($"Divide: 20 / 4 = {basicMath.Divide(20, 4)}");

            Console.WriteLine("\nAdvanced Math Operations:");
            Console.WriteLine($"Square: 5^2 = {advancedMath.Square(5)}");
            Console.WriteLine($"Square Root: √16 = {advancedMath.SquareRoot(16)}");

            // Uncomment the following lines to see exceptions being handled
            // Console.WriteLine($"Divide by zero: 10 / 0 = {basicMath.Divide(10, 0)}");
            // Console.WriteLine($"Square Root of negative number: √-1 = {advancedMath.SquareRoot(-1)}");
        }
    }
}
