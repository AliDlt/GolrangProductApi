namespace GolrangProductApi.Application.DTOs
{
    public class ProductMaterialDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public bool IsJeld { get; set; }
        public bool Required { get; set; }
        public bool IsCustomCirculation { get; set; }
        public bool IsCombinedMaterial { get; set; }
        public int Weight { get; set; }
        public ICollection<ProductMaterialAttributeDto> Attributes { get; set; }
    }
}
