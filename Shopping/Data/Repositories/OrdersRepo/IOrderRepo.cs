using Shopping.Data.Models;
using Shopping.Data.Repositories.GenericRepo;

namespace Shopping.Data.Repositories.OrdersRepo
{
    public interface IOrderRepo:IGenericRepo<Order>
    {
        public List<Order> GetAllIncludingItems();
        public Order GetByIdIncludingChilds(Guid orderId);
    }
}
