using System;
using System.Threading;
using System.Threading.Tasks;
using Twitterjack.Data.Access;

namespace Twitterjack.Bot
{
    public class TwitterBot
    {
        private const int RefreshRateMillis = 60 * 1000;
        private readonly ICreatorClient _creatorClient;
        
        public TwitterBot(ICreatorClient creatorClient)
        {
            _creatorClient = creatorClient;
        }

        public async Task Run()
        {
            while (true)
            {
                var creators = await _creatorClient.GetCreators();
                Console.WriteLine($"There were {creators.Count} creators");
                Thread.Sleep(RefreshRateMillis);
            }
        }
    }
}