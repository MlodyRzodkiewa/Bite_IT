using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class MealProfile : Profile
    {
        public MealProfile()
        {
            CreateMap<Meal, CreateMealDto>().ReverseMap();
            CreateMap<Meal, UpdateMealDto>().ReverseMap();
            CreateMap<Meal, MealDto>().ReverseMap();
        }
    }
}