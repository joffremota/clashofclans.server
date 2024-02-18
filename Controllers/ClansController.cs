using clashofclans.server.Helpers.Configurations;
using clashofclans.server.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace clashofclans.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClansController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ClansController(IHttpClientFactory httpClientFactory)
            => _httpClientFactory = httpClientFactory;

        [HttpGet("GetClanDataByTag")]
        public async Task<ActionResult<ClanData>> GetClanDataByTag(string clanTag)
        {
            var apiUrl = $"https://api.clashofclans.com/v1/clans/{clanTag}";
            var x = new GeneralSettings();
            using var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", x.ObterToken());

            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var clanData = JsonConvert.DeserializeObject<ClanData>(content);
                if (clanData != null) return clanData;
                else return new NotFoundResult();
            }
            else
            {
                // Trate os erros conforme necessário
                throw new Exception($"Falha ao obter dados do clan. Status: {response.StatusCode}");
            }
        }
    }
}
