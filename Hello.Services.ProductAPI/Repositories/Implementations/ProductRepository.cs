using Hello.Services.ProductAPI.Models;
using Hello.Services.ProductAPI.Repositories.Interfaces;

namespace Hello.Services.ProductAPI.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
