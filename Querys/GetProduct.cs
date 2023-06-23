using MediatR;
using Session3_BoilerPlate.Models;

namespace Session3_BoilerPlate.Querys
{
    public class GetProduct : IRequest<Product>
    {
        public int Id { get; set; }
    }

}
