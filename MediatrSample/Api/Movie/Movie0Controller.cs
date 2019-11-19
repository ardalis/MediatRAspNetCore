using MediatrSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{
    [Route("/[controller]/[action]")]
    public class Movie0Controller : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public Movie0Controller(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]NewMovieDTO newMovie)
        {
            var movie = new Movie
            {
                Id = newMovie.Id,
                Name = newMovie.Name
            };
            _movieRepository.Create(movie);
            return Ok(movie);
        }
    }
}
