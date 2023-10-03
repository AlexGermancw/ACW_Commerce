using Catalog.Service.EventHandlers.Commands;
using Catalog.Services.Querries;
using Catalog.Services.Querries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductQuerryService _productQuerryService;
        private readonly IMediator _mediator;
        public ProductController(
            ILogger<ProductController> logger,
            IProductQuerryService productQuerryService,
            IMediator mediator)
        {
            _logger = logger;
            _productQuerryService = productQuerryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if(!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productQuerryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            return await _productQuerryService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    }
}