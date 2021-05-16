using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using Owlbear.Dto.Remote.Twitter;
using Owlbear.Model;
using Owlbear.Utilities;
using JsonException = System.Text.Json.JsonException;

namespace Owlbear.Repository.Remote
{
    public class RemoteTwitterRepository : IRemoteTwitterRepository
    {
        private const string TwitterApiUserByName = "https://api.twitter.com/2/users/by/username/";
        private const string TwitterApiRecentTweets = "https://api.twitter.com/2/users/:id/tweets/";
        private readonly string _bearerToken = NetUtils.TwitterBearerToken;
        private readonly HttpClient _client = NetUtils.Client;
        private readonly IMapper _mapper;

        public RemoteTwitterRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<Twitter> GetTwitter(string handle)
        {
            var query = new NetUtils.QueryBuilder(TwitterApiUserByName + handle);
            query["user.fields"] += new[]{"description", "profile_image_url", "public_metrics"};
            using var request = new HttpRequestMessage(HttpMethod.Get, query.ToString());
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var dto = JsonConvert.DeserializeObject<RemoteTwitterResponseDto>(content);
            var twitter = _mapper.Map<Twitter>(dto);
            twitter.Tweets = await GetRecentTweets(twitter.RemoteId);
            return twitter;
        }

        private async Task<List<Tweet>> GetRecentTweets(string id)
        {
            var query = new NetUtils.QueryBuilder($"https://api.twitter.com/2/users/{id}/tweets");
            query["exclude"] += new[]{"retweets", "replies"};
            query["tweet.fields"] += "public_metrics";
            query["max_results"] += "5"; // 5 is minimum allowed
            using var request = new HttpRequestMessage(HttpMethod.Get, query.ToString());
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var dto = JsonConvert.DeserializeObject<RemoteTwitterTweetsResponseDto>(content);
            if (dto == null) throw new JsonException();
            return _mapper.Map<List<Tweet>>(dto.data);
        }
    }
}