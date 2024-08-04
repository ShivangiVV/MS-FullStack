namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers");
            int x= int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum is {x + y}");
        }
    }
}
