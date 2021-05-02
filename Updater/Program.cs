using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Owlbear.Dto.Creator;

namespace Updater
{
    class Program
    {
        
        private static readonly HttpClient Client = new();
        
        static async Task Main(string[] args)
        {
            while (true)
            {
                using var getRequest = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/api/creators");
                var response = await Client.SendAsync(getRequest);
                var content = await response.Content.ReadAsStringAsync();
                var tracked = new List<CreatorDto>();
                try
                {
                    var dtoList = JsonConvert.DeserializeObject<List<CreatorDto>>(content);
                    if (dtoList != null) tracked = dtoList;
                }
                catch (JsonException e)
                {
                }
                foreach (var creator in tracked)
                {
                    using var patchRequest = new HttpRequestMessage(HttpMethod.Patch, $"https://localhost:5001/api/creators/{creator.Id}");
                    await Client.SendAsync(patchRequest);
                }
                System.Threading.Thread.Sleep(1000 * 60 * 60);
            }
            
        }
    }
}