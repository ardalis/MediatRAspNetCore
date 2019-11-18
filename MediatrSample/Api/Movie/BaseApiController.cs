using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatrSample.Api.Movie
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        public IMediator Mediator { get; set; }
    }
}
