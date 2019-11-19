using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{

    public class NewMovieHandler : IRequestHandler<NewMovieCommand,Movie>
    {
        Task<Movie> IRequestHandler<NewMovieCommand, Movie>.Handle(NewMovieCommand request, 
            CancellationToken cancellationToken)
        {
            // TODO: real work here like saving the movie

            return Task.FromResult(new Movie { Id = request.Id, Name = request.Name });
        }
    }
}
