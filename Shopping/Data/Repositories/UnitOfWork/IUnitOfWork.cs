

using Shopping.Data.Repositories.OrdersRepo;
using Shopping.Data.Repositories.ProductRepo;

namespace Shopping.Data.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IProductRepo ProductRepo { get; }
        public IOrderRepo OrderRepo { get; }

    }
}
