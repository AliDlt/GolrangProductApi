namespace GolrangProductApi.Application.DTOs
{
    public class ProductAdtDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAdtTypeId { get; set; }
        public bool Required { get; set; }
        public byte Side { get; set; }
        public int Count { get; set; }
        public bool IsJeld { get; set; }
        public ProductAdtTypeDto ProductAdtType { get; set; }
    }
}
