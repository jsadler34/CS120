namespace GA_ConsoleReadLine_Jake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            // Accept User Input
            String username = Console.ReadLine();
            // Replay User Input
            Console.WriteLine("Hello " + username + "!");
            // Ask for Favorite Color
            Console.WriteLine("What is your favorite color?");
            // Get Response
            string color = Console.ReadLine();
            // Respond
            Console.WriteLine(color + " is a great color, " + username);
        }
    }
}
