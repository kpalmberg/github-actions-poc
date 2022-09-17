namespace dotnet_lint_testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputText = "Hello there...world."; // Changing indentation here is an example to make this throw a linting error with Super-Linter
            Console.WriteLine(outputText);
        }
    }
}