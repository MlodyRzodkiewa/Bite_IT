using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class OrderLineProfile : Profile
    {
        public OrderLineProfile()
        {
            CreateMap<OrderLine, CreateOrderLineDto>().ReverseMap();
            CreateMap<OrderLine, UpdateOrderLineDto>().ReverseMap();
            CreateMap<OrderLine, OrderLineDto>().ReverseMap();
        }
    }
}