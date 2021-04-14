using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using Owlbear.Dto.Remote.Twitch;
using Owlbear.Dto.Remote.Twitter;
using Owlbear.Model;
using Owlbear.Utilities;

namespace Owlbear.Repository.Remote
{
    public class RemoteTwitchRepository : IRemoteTwitchRepository
    {
        private const string TwitchApiUserByLogin = "https://api.twitch.tv/helix/users";
        private const string TwitchApiFollowersById = "https://api.twitch.tv/helix/users/follows";
        private readonly string _clientId = NetUtils.TwitchClientId;
        private readonly string _bearerToken = NetUtils.TwitchBearerToken;
        private readonly HttpClient _client = NetUtils.Client;
        private readonly IMapper _mapper;

        public RemoteTwitchRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<Twitch> GetTwitch(string handle)
        {
            var user = await GetUser(handle);
            var followers = await GetFollowers(user.data[0].id);
            var twitch = _mapper.Map<RemoteTwitchUserResponseDto, Twitch>(user);
            _mapper.Map(followers, twitch);
            return twitch;
        }

        private async Task<RemoteTwitchUserResponseDto> GetUser(string handle)
        {
            var userQuery = new NetUtils.QueryBuilder(TwitchApiUserByLogin);
            userQuery["login"] += handle;
            using var request = new HttpRequestMessage(HttpMethod.Get, userQuery.ToString());
            request.Headers.Add("client-id", _clientId);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var dto = JsonConvert.DeserializeObject<RemoteTwitchUserResponseDto>(content);
                // TODO: Safe null checks and for specific necessary attributes like id with custom exception
                return dto;
            }
            catch (JsonException e)
            {
                throw new Exception(e.Message); // TODO: Throw new custom exception
            }
        }

        private async Task<RemoteTwitchFollowersResponseDto> GetFollowers(string id)
        {
            var userQuery = new NetUtils.QueryBuilder(TwitchApiFollowersById);
            userQuery["to_id"] += id;
            using var request = new HttpRequestMessage(HttpMethod.Get, userQuery.ToString());
            request.Headers.Add("Client-Id", _clientId);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var dto = JsonConvert.DeserializeObject<RemoteTwitchFollowersResponseDto>(content);
                // TODO: Safe null checks and for specific necessary attributes like id with custom exception
                return dto;
            }
            catch (JsonException e)
            {
                throw new Exception(e.Message); // TODO: Throw new custom exception
            }
        }
    }
}