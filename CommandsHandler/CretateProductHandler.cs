using MediatR;
using Microsoft.EntityFrameworkCore;
using Session3_BoilerPlate.AppDBContext;
using Session3_BoilerPlate.Commands;
using Session3_BoilerPlate.Models;

namespace Session3_BoilerPlate.CommandsHandler
{
    public class CretateProductHandler : IRequestHandler<CreateProduct,Product>
    {
        private readonly ProductDb _productDb;

        public CretateProductHandler(ProductDb productDb)
        {
            _productDb = productDb;
        }

        public async Task<Product> Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                ProductName = request.Name,
                ProductPrice = request.Price
            };

            _productDb.ProductsDB.Add(product);
            await _productDb.SaveChangesAsync(cancellationToken);

            return product;
        }
    }

}
