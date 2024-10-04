namespace GolrangProductApi.Domain.Entities
{
    public class ProductSize
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public string Name { get; set; }
        public int SheetDimensionId { get; set; }

        // Navigation Properties
        public Product Product { get; set; }
    }

}
