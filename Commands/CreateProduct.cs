using MediatR;
using Session3_BoilerPlate.Models;

namespace Session3_BoilerPlate.Commands
{
    public class CreateProduct : IRequest<Product>
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
