using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrSample.Api.Movie
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
    public class NewMovieCommand : IRequest<Movie>
    {
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class NewMovieHandler : IRequestHandler<NewMovieCommand,Movie>
    {

        Task<Movie> IRequestHandler<NewMovieCommand, Movie>.Handle(NewMovieCommand request, 
            CancellationToken cancellationToken)
        {
            return Task.FromResult(new Movie { Id = request.Id, Name = request.Name });
        }
    }
}
