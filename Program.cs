namespace GitCSharpDemo.Core;

public static class Program
{
    public static void Main(string[] args)
    {
        string name = "Guest";

        while (true)
        {
            Console.WriteLine("\n--- Greeting App ---");
            Console.WriteLine("1. Set your name");
            Console.WriteLine("2. Show greeting");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            // End gracefully if the input stream is closed.
            if (choice is null)
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your name: ");
                    string? input = Console.ReadLine();

                    name = string.IsNullOrWhiteSpace(input)
                        ? "Guest"
                        : input.Trim();

                    Console.WriteLine($"Name saved: {name}");
                    break;

                case "2":
                    Console.WriteLine($"Hello, {name}!");
                    break;

                case "3":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Choose 1, 2, or 3.");
                    break;
            }
        }
    }
}