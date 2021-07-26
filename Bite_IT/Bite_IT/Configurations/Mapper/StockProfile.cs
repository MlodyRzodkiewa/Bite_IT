using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Stock, CreateStockDto>().ReverseMap();
            CreateMap<Stock, UpdateStockDto>().ReverseMap();
            CreateMap<Stock, StockDto>().ReverseMap();
        }
    }
}