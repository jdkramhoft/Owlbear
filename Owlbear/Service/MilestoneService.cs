using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Owlbear.Model;
using Owlbear.Repository.Remote;
using Owlbear.Utilities;
using Tweetinvi;

namespace Owlbear.Service
{
    public class MilestoneService : IMilestoneService
    {
        private static readonly TwitterClient TwitterClient = new TwitterClient(NetUtils.TwitterApiKey, NetUtils.TwitterApiSecret, NetUtils.TwitterAccessToken, NetUtils.TwitterAccessSecret);
        private readonly List<int> _milestones;
        private readonly HttpClient _client = NetUtils.Client;
        private readonly IRemoteTwitterRepository _remoteTwitterRepository;

        public MilestoneService(IRemoteTwitterRepository remoteTwitterRepository)
        {
            _remoteTwitterRepository = remoteTwitterRepository;
            _milestones = new List<int>();
            AddMilestones(_milestones);
        }

        private static void AddMilestones(ICollection<int> milestones)
        {
            for (var i = 0; i < 19; i++)
            {
                milestones.Add(5000 * i);
            }
            for (var i = 1; i <= 9; i++)
            {
                milestones.Add(100_000 * i);
                milestones.Add(100_000 * i + 50_000);
            }

            for (var i = 1; i <= 10; i++)
            {
                milestones.Add(1_000_000 * i);
            }
        }

        public async Task TweetMilestones(Creator creator, Creator updated)
        {
            var tasks = new List<Task>();
            var hasTwitter = creator.Twitter != null && updated.Twitter != null;
            if (hasTwitter) tasks.Add(TweetTwitterMilestones(creator, updated));
            var hasYoutube = creator.Youtube != null && updated.Youtube != null;
            if (hasYoutube) tasks.Add(TweetYoutubeMilestones(creator, updated));
            var hasTwitch = creator.Twitch != null && updated.Twitch != null;
            if (hasTwitch) tasks.Add(TweetTwitchMilestones(creator, updated));
            await Task.WhenAll(tasks);
        }

        private async Task TweetTwitterMilestones(Creator previous, Creator updated)
        {
            foreach (var milestone in _milestones)
            {
                var milestoneReached = previous.Twitter.Followers < milestone && milestone <= updated.Twitter.Followers;
                if (!milestoneReached) continue;
                var msg = $"Congratulations to @{updated.Twitter.Handle} for reaching {milestone} Twitter followers!";
                await SendTweet(msg);
            }
        }

        private async Task TweetYoutubeMilestones(Creator previous, Creator updated)
        {
            foreach (var milestone in _milestones)
            {
                var milestoneReached = previous.Youtube.Subscribers < milestone && milestone <= updated.Youtube.Subscribers;
                if (!milestoneReached) continue;
                var handle = updated.Twitter != null ? updated.Twitter.Handle : updated.Name;
                var msg = $"Congratulations to @{handle} for reaching {milestone} Youtube subscribers!";
                await SendTweet(msg);
            }
        }

        private async Task TweetTwitchMilestones(Creator previous, Creator updated)
        {
            foreach (var milestone in _milestones)
            {
                var milestoneReached = previous.Twitch.Followers < milestone && milestone <= updated.Twitch.Followers;
                if (!milestoneReached) continue;
                var handle = updated.Twitter != null ? updated.Twitter.Handle : updated.Name;
                var msg = $"Congratulations to @{handle} for reaching {milestone} Twitch followers!";
                await SendTweet(msg);
            }
        }

        private async Task SendTweet(string msg)
        {
            var tweet = await TwitterClient.Tweets.PublishTweetAsync(msg);
        }

        public async Task<List<Milestone>> GetAllMilestonesAsync()
        {
            return (await _remoteTwitterRepository.GetTwitter("MilestoneCyan")).Tweets.Select(tweet => new Milestone(){Tweet = tweet}).ToList();
        }
    }
}