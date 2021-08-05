using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class MealsIngredientsProfile : Profile
    {
        public MealsIngredientsProfile()
        {
            CreateMap<MealsIngredients, CreateMealsIngredientsDto>().ReverseMap();
            CreateMap<MealsIngredients, UpdateMealsIngredientsDto>().ReverseMap();
            CreateMap<MealsIngredients, MealsIngredientsDto>().ReverseMap();
        }
    }
}