namespace Bosch.Calculator
{
    public class AdvancedMath
    {
        public double Square(double a)
        {
            return a * a;
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot calculate the square root of a negative number.");
            }
            return Math.Sqrt(a);
        }
    }
}
