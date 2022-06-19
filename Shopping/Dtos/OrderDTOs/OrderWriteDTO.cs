using Shopping.Dtos.OrderItemDTOs;

namespace Shopping.Dtos.OrderDTOs
{
    public record OrderWriteDTO
    {
        public List<OrderItemChildWriteDTO> OrderItems { get; init; }
    }
}
