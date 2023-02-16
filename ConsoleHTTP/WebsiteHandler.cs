namespace ConsoleHTTP
{
    internal class WebsiteHandler
    {
        public async Task<string> HandleRequest(string url, HttpClient client) {
            RegexHandler regex = new RegexHandler();
            try
            {
                url = "http://" + url;
                using HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                string output = regex.StripHTML(responseBody);
                return output;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}