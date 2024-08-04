namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] marks = new int[5];
            int sum = 0;
            Console.WriteLine("Hello, enter your marks");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                sum += marks[i];

            }
           
            Console.WriteLine($"The average is {sum}");
        }
    }
}
