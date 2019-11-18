using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{

    [Route("/[controller]/[action]")]
    public class MovieController : BaseApiController
    {
        [HttpPost]
        [Ardalis.Filters.ValidateModel]
        public async Task<IActionResult> Create([FromBody]NewMovieCommand command)
        {
            // var result = await _mediator.Send(command);
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
