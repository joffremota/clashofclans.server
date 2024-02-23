using clashofclans.server.Models;
using MediatR;

namespace clashofclans.server.Services.Query
{
    public class GetClanDataByTagQuery : IRequest<QuerySimpleStatusResponse<ClanData>>
    {
        public string Tag { get; set; }

        public GetClanDataByTagQuery(string tag)
            => Tag = tag;
    }
}
