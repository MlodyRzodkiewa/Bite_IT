using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            CreateMap<Menu, CreateMenuDto>().ReverseMap();
            CreateMap<Menu, UpdateMenuDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
        }
    }
}