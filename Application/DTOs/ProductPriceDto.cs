namespace GolrangProductApi.Application.DTOs
{
    public class ProductPriceDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Price { get; set; }
        public int Circulation { get; set; }
        public bool IsDoubleSided { get; set; }
        public int PageCount { get; set; }
        public int CopyCount { get; set; }
        public int ProductSizeId { get; set; }
        public int ProductMaterialId { get; set; }
        public int ProductMaterialAttributeId { get; set; }
        public bool IsJeld { get; set; }
        public int ProductPrintKindId { get; set; }
    }
}
