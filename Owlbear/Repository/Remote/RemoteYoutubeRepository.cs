using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using Owlbear.Dto.Remote.Twitch;
using Owlbear.Dto.Remote.Youtube;
using Owlbear.Model;
using Owlbear.Utilities;

namespace Owlbear.Repository.Remote
{
    public class RemoteYoutubeRepository : IRemoteYoutubeRepository
    {
        private const string YoutubeChannelApi = "https://www.googleapis.com/youtube/v3/channels";
        private readonly string _apiKey = NetUtils.YoutubeApiKey;
        private readonly HttpClient _client = NetUtils.Client;
        private readonly IMapper _mapper;

        public RemoteYoutubeRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<Youtube> GetYoutube(string channelId)
        {
            var query = new NetUtils.QueryBuilder(YoutubeChannelApi);
            query["part"] += "statistics";
            query["id"] += channelId;
            query["key"] += _apiKey;
            using var request = new HttpRequestMessage(HttpMethod.Get, query.ToString());
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var dto = JsonConvert.DeserializeObject<RemoteYoutubeResponseDto>(content);
                return _mapper.Map<Youtube>(dto);
            }
            catch (JsonException e)
            {
                throw new Exception(e.Message); // TODO: Throw new custom exception
            }
        }
    }
}