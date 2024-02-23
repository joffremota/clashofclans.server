using clashofclans.server.Models;
using clashofclans.server.Services.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace clashofclans.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClansController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet("GetClanDataByTag")]
        public async Task<ActionResult<ClanData>> GetClanDataByTag(string clanTag)
        {
            var query = new GetClanDataByTagQuery(clanTag);
            var resultQuery = await _mediator.Send(query);
            return Ok(resultQuery);
        }
    }
}
