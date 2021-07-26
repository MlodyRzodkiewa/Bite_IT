using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}