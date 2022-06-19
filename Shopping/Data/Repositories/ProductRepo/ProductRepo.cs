using Shopping.Data.Context;
using Shopping.Data.Models;
using Shopping.Data.Repositories.GenericRepo;

namespace Shopping.Data.Repositories.ProductRepo
{
    public class ProductRepo : GenericRepo<Product>, IProductRepo
    {
        public ProductRepo(ShoppingContext _context) : base(_context)
        {
        }
    }
}
