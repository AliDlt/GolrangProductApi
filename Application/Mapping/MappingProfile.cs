using AutoMapper;
using GolrangProductApi.Application.DTOs;
using GolrangProductApi.Domain.Entities;

namespace GolrangProductApi.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductAdt, ProductAdtDto>().ReverseMap();
            CreateMap<ProductAdtType, ProductAdtTypeDto>().ReverseMap();
            CreateMap<ProductDeliver, ProductDeliverDto>().ReverseMap();
            CreateMap<ProductDeliverSize, ProductDeliverSizeDto>().ReverseMap();
            CreateMap<ProductMaterial, ProductMaterialDto>().ReverseMap();
            CreateMap<ProductMaterialAttribute, ProductMaterialAttributeDto>().ReverseMap();
            CreateMap<ProductPrice, ProductPriceDto>().ReverseMap();
            CreateMap<ProductPrintKind, ProductPrintKindDto>().ReverseMap();
            CreateMap<ProductSize, ProductSizeDto>().ReverseMap();
            CreateMap<WorkType, WorkTypeDto>().ReverseMap();
        }
    }
}
