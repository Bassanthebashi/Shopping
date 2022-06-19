namespace Shopping.Dtos.ProductDTOs
{
    public record ProductChildReadDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int Stock { get; init; }
        public decimal Price { get; init; }
        public string Image { get; init; }

    }
}
