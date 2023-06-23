using MediatR;
using Microsoft.EntityFrameworkCore;
using Session3_BoilerPlate.AppDBContext;
using Session3_BoilerPlate.Models;
using Session3_BoilerPlate.Querys;

namespace Session3_BoilerPlate.QueryHandler
{
    public class GetAllProductQH : IRequestHandler<GetAllProducts, List<Product>>
    {
        private readonly ProductDb _productDb;


        public GetAllProductQH(ProductDb productDb)
        {
            _productDb = productDb;
        }

        public async Task<List<Product>> Handle(GetAllProducts request, CancellationToken cancellationToken)
        {
            return await _productDb.ProductsDB.ToListAsync(cancellationToken);
        }
    }
}




