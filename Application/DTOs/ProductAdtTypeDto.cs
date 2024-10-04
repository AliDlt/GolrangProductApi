namespace GolrangProductApi.Application.DTOs
{
    public class ProductAdtTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductAdtDto> ProductAdts { get; set; }
    }
}
