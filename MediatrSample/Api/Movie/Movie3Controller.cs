using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{
    public class Movie3Controller : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]NewMovieCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
