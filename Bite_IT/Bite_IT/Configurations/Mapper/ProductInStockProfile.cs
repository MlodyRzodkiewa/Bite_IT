using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class ProductInStockProfile : Profile
    {
        public ProductInStockProfile()
        {
            CreateMap<ProductInStock, CreateProductInStockDto>().ReverseMap();
            CreateMap<ProductInStock, UpdateProductInStockDto>().ReverseMap();
            CreateMap<ProductInStock, ProductInStockDto>().ReverseMap();
        }
    }
}