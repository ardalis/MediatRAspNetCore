using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{

    public class NewMovieHandler : IRequestHandler<NewMovieCommand,Movie>
    {
        private readonly IMovieRepository _movieRepository;

        public NewMovieHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        Task<Movie> IRequestHandler<NewMovieCommand, Movie>.Handle(NewMovieCommand newMovieCommand, 
            CancellationToken cancellationToken)
        {
            var movie = new Movie
            {
                Id = newMovieCommand.Id,
                Name = newMovieCommand.Name
            };
            _movieRepository.Create(movie);

            return Task.FromResult(movie);
        }
    }
}
