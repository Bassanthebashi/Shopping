

using Shopping.Data.Repositories.OrdersRepo;
using Shopping.Data.Repositories.ProductRepo;

namespace Shopping.Data.Repositories.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public IProductRepo ProductRepo { get; }
        public IOrderRepo OrderRepo { get; }
        public UnitOfWork(IProductRepo productRepo,IOrderRepo orderRepo)
        {
            ProductRepo = productRepo;
            OrderRepo = orderRepo;
        }

    }
}
