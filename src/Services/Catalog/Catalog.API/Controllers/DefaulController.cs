using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaulController : ControllerBase
    {

        private readonly ILogger<DefaulController> _logger;

        public DefaulController(ILogger<DefaulController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}