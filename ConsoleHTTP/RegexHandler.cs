using System.Text.RegularExpressions;

namespace ConsoleHTTP
{
    internal class RegexHandler
    {
        public string StripHTML(string input)
        {
            var tempInput = Regex.Replace(input, "<.*?>", String.Empty);
            return tempInput;
        }
    }
}
