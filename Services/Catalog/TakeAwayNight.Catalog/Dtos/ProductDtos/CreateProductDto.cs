﻿namespace TakeAwayNight.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        
        public string ProductName { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
