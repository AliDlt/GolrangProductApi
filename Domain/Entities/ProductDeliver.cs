namespace GolrangProductApi.Domain.Entities
{
    public class ProductDeliver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Circulation { get; set; }
        public int ProductId { get; set; }
        public bool IsIncreased { get; set; }
        public int StartCirculation { get; set; }
        public int EndCirculation { get; set; }
        public int PrintSide { get; set; }
        public float Price { get; set; }
        public int CalcType { get; set; }

        // Navigation Properties
        public Product Product { get; set; }
        public ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; }
    }
}
