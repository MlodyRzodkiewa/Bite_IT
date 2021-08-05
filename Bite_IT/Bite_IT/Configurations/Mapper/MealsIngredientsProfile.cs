using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class MealsIngredientsProfile : Profile
    {
        public MealsIngredientsProfile()
        {
            CreateMap<MealsIngredient, CreateMealsIngredientsDto>().ReverseMap();
            CreateMap<MealsIngredient, UpdateMealsIngredientsDto>().ReverseMap();
            CreateMap<MealsIngredient, MealsIngredientsDto>().ReverseMap();
        }
    }
}