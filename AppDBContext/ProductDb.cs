using Microsoft.EntityFrameworkCore;
using Session3_BoilerPlate.Models;

namespace Session3_BoilerPlate.AppDBContext
{
    public class ProductDb : DbContext
    {

        public ProductDb(DbContextOptions<ProductDb> Context) : base(Context)
        {

        }

        public DbSet<Product> ProductsDB { get; set; }



    }
}
