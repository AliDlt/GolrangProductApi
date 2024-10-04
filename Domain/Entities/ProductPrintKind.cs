namespace GolrangProductApi.Domain.Entities
{
    public class ProductPrintKind
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PrintKindId { get; set; }
        public bool IsJeld { get; set; } = false;

        // Navigation Properties
        public Product Product { get; set; }
    }
}
