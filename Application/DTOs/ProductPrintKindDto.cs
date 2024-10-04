namespace GolrangProductApi.Application.DTOs
{
    public class ProductPrintKindDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PrintKindId { get; set; }
        public bool IsJeld { get; set; }
    }
}
