namespace Shopping.Dtos.OrderItemDTOs
{
    public record OrderItemChildWriteDTO
    {
        public Guid ProductId { get; init; }

        public int ProductQuantity { get; init; }

    }
}
