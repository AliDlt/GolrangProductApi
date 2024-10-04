namespace GolrangProductApi.Application.DTOs
{
    public class ProductSizeDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public string Name { get; set; }
        public int SheetDimensionId { get; set; }
    }
}
