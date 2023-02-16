using ConsoleHTTP;

internal class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        Console.WriteLine("Enter the websites adress (don't include the http). Example: www.google.dk");
        while (true)
        {
            string userInput = Console.ReadLine();
            WebsiteHandler handler = new WebsiteHandler();
            if (userInput != null)
            {
                Console.WriteLine(await handler.HandleRequest(userInput, client));
            }
            else
            {
                Console.WriteLine("Please enter something before proceeding");
            }
            Console.WriteLine("Enter the websites adress (don't include the http). Example: www.google.dk");
        }
    }
}