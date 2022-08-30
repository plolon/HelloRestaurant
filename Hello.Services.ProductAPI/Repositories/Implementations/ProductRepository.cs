using Hello.Services.ProductAPI.Models;
using Hello.Services.ProductAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hello.Services.ProductAPI.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
