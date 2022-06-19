using Shopping.Dtos.OrderItemDTOs;

namespace Shopping.Dtos.OrderDTOs
{
    public record OrderReadDTO
    {
        public Guid Id { get; init; }

        public string User { get; init; }

        public bool Approval { get; init; }

        public List<OrderItemChildReadDTO> OrderItems { get; init; }
    }
}
