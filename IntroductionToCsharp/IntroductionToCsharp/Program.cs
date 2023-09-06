namespace IntroductionToCsharp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your name : ");
            string? Name = Console.ReadLine();

            Console.WriteLine("Your name is "+ Name);
            Console.WriteLine($"Your name is {Name}");
            Console.WriteLine("Your name is {0}", Name);

        }
    }
}