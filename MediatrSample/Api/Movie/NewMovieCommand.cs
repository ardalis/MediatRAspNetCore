using MediatR;
using System.ComponentModel.DataAnnotations;

namespace MediatrSample.Api.Movie
{
    public class NewMovieCommand : IRequest<Movie>
    {
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
