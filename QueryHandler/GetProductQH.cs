using MediatR;
using Microsoft.EntityFrameworkCore;
using Session3_BoilerPlate.AppDBContext;
using Session3_BoilerPlate.Models;
using Session3_BoilerPlate.Querys;

namespace Session3_BoilerPlate.QueryHandler
{
    public class GetProductQH : IRequestHandler<GetProduct, Product>
    {
        private readonly ProductDb _productDb;

    public GetProductQH(ProductDb productDb)
    {
        _productDb = productDb;
    }

    public async Task<Product> Handle(GetProduct request, CancellationToken cancellationToken)
    {
        return await _productDb.ProductsDB.FindAsync(request.Id);
    }
}
    
}
