using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Mvc;

namespace MyMediatrDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("index")]
        public async Task<int> Get()
        {
            return await Task.FromResult(5);
        }
    }
}
