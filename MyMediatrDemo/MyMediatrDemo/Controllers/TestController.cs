using MediatR;
using MediatrInfrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using MediatrInfrastructure.Handlers.Queries;

namespace MyMediatrDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("index")]
        public async Task<TestQueryResult> Get()
        {
            return await _mediator.Send(new TestQuery(), CancellationToken.None);
        }
    }
}
