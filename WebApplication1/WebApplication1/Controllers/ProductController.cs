using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.MediatR.Commands;
using WebApplication1.MediatR.Queries;

namespace WebApplication1.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator= mediator;
        }
        [HttpGet("id")]
        
        public async Task<IActionResult> GetProduct(int id)
        {
            GetProductQuery query = new GetProductQuery() { Id= id };
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand createProductCommand)
        {
            
            return Ok(await _mediator.Send(createProductCommand));
        }
    }
}
