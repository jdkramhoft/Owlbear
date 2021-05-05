using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Owlbear.Dto.Creator;

namespace GUI.DataFromWeb
{
    public class CreatorWebServiceThing
    {
        private const string CreatorApi = "https://localhost:5001/api/creators";
        private readonly HttpClient _client = AlsoWebUtils.Client;
        
        public async Task<CreatorDto> GetCreator(int id)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, CreatorApi + $"/{id}");
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var dto = JsonConvert.DeserializeObject<CreatorDto>(content);
                return dto;
            }
            catch (JsonException e)
            {
                Console.WriteLine("Uh oh! JSON");
                throw; // TODO: Throw new custom exception
            }
        }

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
                Console.WriteLine("Uh oh! JSON GetCreators");
                throw; // TODO: Throw new custom exception
            }
        }
        
        public async Task<CreatorDto> UpdateCreator(int id, UpdateCreatorDto dto)
        {
            using var request = new HttpRequestMessage(HttpMethod.Put, CreatorApi + $"/{id}");
            request.Content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var responseDto = JsonConvert.DeserializeObject<CreatorDto>(content);
                return responseDto;
            }
            catch (JsonException e)
            {
                Console.WriteLine("Uh oh! JSON");
                throw; // TODO: Throw new custom exception
            }
        }

        public async Task<CreatorDto> DeleteCreator(int id)
        {
            using var request = new HttpRequestMessage(HttpMethod.Delete, CreatorApi + $"/{id}");
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var dto = JsonConvert.DeserializeObject<CreatorDto>(content);
                return dto;
            }
            catch (JsonException e)
            {
                Console.WriteLine("Uh oh! JSON");
                throw; // TODO: Throw new custom exception
            }
        }

        public async Task<CreatorDto> CreateCreator(CreateCreatorDto dto)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, CreatorApi);
            request.Content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var responseDto = JsonConvert.DeserializeObject<CreatorDto>(content);
                return responseDto;
            }
            catch (JsonException e)
            {
                Console.WriteLine("Uh oh! JSON");
                throw; // TODO: Throw new custom exception
            }
        }
    }
}