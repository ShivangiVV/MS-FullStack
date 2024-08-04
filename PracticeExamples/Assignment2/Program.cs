namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your name - ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your age - ");
                int age = int.Parse(Console.ReadLine());
                if (age < 70)
                {
                    //Interpolation syntax
                    Console.WriteLine($"Hello {name}, Welcome to the racing club!");
                }
                else
                {
                    Console.WriteLine($"Sorry {name}, you cant be the part of Race Club");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
