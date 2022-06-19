using Shopping.Data.Models;
using Shopping.Dtos.ProductDTOs;

namespace Shopping.Dtos.OrderItemDTOs
{
    public record OrderItemChildReadDTO
    {
        public Guid Id { get; init; }
        public Guid ProductId { get; init; }
        public int ProductQuantity { get; init; }
        public ProductChildReadDTO Product { get; init; }
    }
}
