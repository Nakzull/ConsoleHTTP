using System.Text.RegularExpressions;

class Program
{
    static readonly HttpClient client = new HttpClient();
    
    static async Task Main()
    {
        try
        {
            using HttpResponseMessage response = await client.GetAsync("https://www.google.dk");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(StripHTML(responseBody));
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
        static string StripHTML(string input)
        {
            var tempInput = Regex.Replace(input, "<.*?>", String.Empty);
            Regex.Replace(tempInput, "<.*?>", String.Empty);
            return tempInput;
        }
    }
}