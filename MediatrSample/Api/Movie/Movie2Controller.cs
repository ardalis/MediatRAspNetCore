using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{

    [Route("/[controller]/[action]")]
    public class Movie2Controller : Controller
    {
        private readonly IMediator _mediator;

        public Movie2Controller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]NewMovieCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
