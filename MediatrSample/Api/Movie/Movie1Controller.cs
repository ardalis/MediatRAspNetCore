using MediatR;
using MediatrSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{

    [Route("/[controller]/[action]")]
    public class Movie1Controller : Controller
    {
        private readonly IMediator _mediator;

        public Movie1Controller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]NewMovieDTO newMovie)
        {
            var command = new NewMovieCommand
            {
                Id = newMovie.Id,
                Name = newMovie.Name
            };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
