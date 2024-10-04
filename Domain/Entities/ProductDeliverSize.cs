namespace GolrangProductApi.Domain.Entities
{
    public class ProductDeliverSize
    {
        public int Id { get; set; }
        public int ProductSizeId { get; set; }
        public int ProductDeliverId { get; set; }

        // Navigation Properties
        public ProductDeliver ProductDeliver { get; set; }
        public ProductSize ProductSize { get; set; }
    }
}
