namespace GolrangProductApi.Domain.Entities
{
    public class ProductAdt
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAdtTypeId { get; set; }
        public bool Required { get; set; } = false;
        public byte Side { get; set; }
        public int Count { get; set; }
        public bool IsJeld { get; set; } = false;

        // Navigation Properties
        public Product Product { get; set; }
        public ProductAdtType ProductAdtType { get; set; }
        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; }
    }
}
