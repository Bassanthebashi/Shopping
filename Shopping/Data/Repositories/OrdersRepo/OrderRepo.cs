using Microsoft.EntityFrameworkCore;
using Shopping.Data.Context;
using Shopping.Data.Models;
using Shopping.Data.Repositories.GenericRepo;

namespace Shopping.Data.Repositories.OrdersRepo
{
    public class OrderRepo : GenericRepo<Order>,IOrderRepo
    {
        private readonly ShoppingContext context;

        public OrderRepo(ShoppingContext _context) : base(_context)
        {
            context = _context;
        }
        public List<Order> GetAllIncludingItems()
        {
            return context.Orders.Include(o=>o.OrderItems).ThenInclude(oi=>oi.Product).ToList();
        }
        public Order GetByIdIncludingChilds(Guid orderId)
        {
            var order = context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).FirstOrDefault(o => o.Id == orderId);
            return order;
        }
    }
}
