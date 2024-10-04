namespace GolrangProductApi.Domain.Entities
{
    public class ProductAdtType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Properties
        public ICollection<ProductAdt> ProductAdts { get; set; }
    }
}
