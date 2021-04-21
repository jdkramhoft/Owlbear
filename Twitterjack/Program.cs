using System;
using System.Threading.Tasks;
using Twitterjack.Bot;
using Twitterjack.Data.Access;

namespace Twitterjack
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ICreatorClient creatorClient = new CreatorClient();
            var twitterBot = new TwitterBot(creatorClient);
            await twitterBot.Run();
        }
    }
}