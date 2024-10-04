namespace GolrangProductApi.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; }
        public int WorkTypeId { get; set; }
        public WorkType WorkType { get; set; }
        public byte ProductType { get; set; }
        public string Circulation { get; set; }
        public string CopyCount { get; set; }
        public string PageCount { get; set; }
        public byte PrintSide { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsCalculatePrice { get; set; } = true;
        public bool IsCustomCirculation { get; set; } = false;
        public bool IsCustomSize { get; set; } = false;
        public bool IsCustomPage { get; set; } = false;
        public int MinCirculation { get; set; }
        public int MaxCirculation { get; set; }
        public int MinPage { get; set; }
        public int MaxPage { get; set; }
        public float MinWidth { get; set; }
        public float MaxWidth { get; set; }
        public float MinLength { get; set; }
        public float MaxLength { get; set; }
        public int SheetDimensionId { get; set; }
        public string FileExtension { get; set; }
        public bool IsCmyk { get; set; } = false;
        public float CutMargin { get; set; }
        public float PrintMargin { get; set; }
        public bool IsCheckFile { get; set; }

        // Navigation Properties
        public ICollection<ProductAdt> ProductAdts { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductMaterial> ProductMaterials { get; set; }
        public ICollection<ProductPrintKind> ProductPrintKinds { get; set; }
        public ICollection<ProductDeliver> ProductDelivers { get; set; }
        public string Name { get; set; }
    }
}
