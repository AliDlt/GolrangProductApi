﻿namespace GolrangProductApi.Domain.Entities
{
    public class ProductPrice
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
        public bool IsJeld { get; set; } = false;
        public int ProductPrintKindId { get; set; }

        // Navigation Properties
        public Product Product { get; set; }
        public ProductSize ProductSize { get; set; }
        public ProductMaterial ProductMaterial { get; set; }
        public ProductMaterialAttribute ProductMaterialAttribute { get; set; }
        public ProductPrintKind ProductPrintKind { get; set; }
    }
}
