using System;

namespace Twitterjack.Configuration
{
    public class WebConfig
    {
        public static readonly string TwitterApiKey = Environment.GetEnvironmentVariable("TWITTER_API_KEY") ?? throw new InvalidOperationException();
        public static readonly string TwitterApiSecret = Environment.GetEnvironmentVariable("TWITTER_API_SECRET") ?? throw new InvalidOperationException();
        public static readonly string TwitterAccessToken = Environment.GetEnvironmentVariable("TWITTER_ACCESS_TOKEN") ?? throw new InvalidOperationException();
        public static readonly string TwitterAccessSecret = Environment.GetEnvironmentVariable("TWITTER_ACCESS_SECRET") ?? throw new InvalidOperationException();

    }
}