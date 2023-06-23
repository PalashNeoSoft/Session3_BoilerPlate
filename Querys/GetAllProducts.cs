using MediatR;
using Session3_BoilerPlate.Models;

namespace Session3_BoilerPlate.Querys
{
    public class GetAllProducts :  IRequest<List<Product>>
    {
    }
}
