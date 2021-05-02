using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Owlbear.Dto.Creator;
using Owlbear.Model;
using Twitterjack.Configuration;

namespace Twitterjack.Data.Access
{
    public class CreatorClient : ICreatorClient
    {
        private const string CreatorApi = "https://localhost:5001/api/creators";

        //private static readonly TwitterClient Client = new TwitterClient(WebConfig.TwitterApiKey, WebConfig.TwitterApiSecret, WebConfig.TwitterAccessToken, WebConfig.TwitterAccessSecret);
        private readonly HttpClient _client = WebUtils.Client;
        
        public async Task<List<CreatorDto>> GetCreators()
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, CreatorApi);
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var dto = JsonConvert.DeserializeObject<List<CreatorDto>>(content);
                return dto;
            }
            catch (JsonException e)
            {
                Console.WriteLine("Uh oh! JSON");
                throw; // TODO: Throw new custom exception
            }
        }
    }
}