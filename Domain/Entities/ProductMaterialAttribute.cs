namespace GolrangProductApi.Domain.Entities
{
    public class ProductMaterialAttribute
    {
        public int Id { get; set; }
        public int ProductMaterialId { get; set; }
        public string AttributeName { get; set; }

        // Navigation Properties
        public ProductMaterial ProductMaterial { get; set; }
    }

}
