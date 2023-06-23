using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session3_BoilerPlate.Commands;
using Session3_BoilerPlate.Models;
using Session3_BoilerPlate.Querys;

namespace Session3_BoilerPlate.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(CreateProduct command)
        {
            var product = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var query = new GetAllProducts();
            var products = await _mediator.Send(query);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var query = new GetProduct { Id = id };
            var product = await _mediator.Send(query);
            if (product == null)
                return NotFound();

            return Ok(product);
        }



    }
}
