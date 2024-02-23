using clashofclans.server.Helpers.Configurations;
using clashofclans.server.Models;
using MediatR;
using Newtonsoft.Json;

namespace clashofclans.server.Services.Query.Handler
{
    public class GetClanDataByTagQueryHandler : IRequestHandler<GetClanDataByTagQuery, QuerySimpleStatusResponse<ClanData>>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GetClanDataByTagQueryHandler(IHttpClientFactory httpClientFactory)
            => _httpClientFactory = httpClientFactory;

        public async Task<QuerySimpleStatusResponse<ClanData>> Handle(GetClanDataByTagQuery request, CancellationToken cancellationToken)
        {
            var generalSettings = new GeneralSettings();
            
            var apiUrl = generalSettings.GetAPIUrl() + request.Tag;
            var token = generalSettings.ObterToken();

            using var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var clanData = JsonConvert.DeserializeObject<ClanData>(content);
                if (clanData != null) return new SuccessQuerySimpleStatusResponse<ClanData>(clanData);
            }
            return new SuccessQuerySimpleStatusResponse<ClanData>(new ClanData());
        }
    }
}
