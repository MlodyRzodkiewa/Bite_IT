using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Models;

namespace Bite_IT.Configurations.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, LoginEmployeeDto>().ReverseMap();
            CreateMap<Employee, RegisterEmployeeDto>().ReverseMap();
        }
    }
}