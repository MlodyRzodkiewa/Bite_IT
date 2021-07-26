using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class RestaurantProfile: Profile
    {
        public RestaurantProfile()
        {
            CreateMap<Restaurant, CreateRestaurantDto>().ReverseMap();
            CreateMap<Restaurant, UpdateRestaurantDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
        }
    }
}