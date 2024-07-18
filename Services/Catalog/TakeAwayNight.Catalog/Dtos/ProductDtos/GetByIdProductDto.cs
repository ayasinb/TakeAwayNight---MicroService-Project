namespace TakeAwayNight.Catalog.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
