using System.Net.Http;

namespace Twitterjack.Configuration
{
    public class WebUtils
    {
        public static readonly HttpClient Client = new();
    }
}