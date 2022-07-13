using AutoMapper;
using Ordering.Application.Commands;
using Ordering.Application.Response;
using Ordering.Core.Entities;

namespace Ordering.Application.Mapper
{
    public class OrderingMappingProfile : Profile
    {
        public OrderingMappingProfile()
        {
            CreateMap<user, UserResponse>().ReverseMap();
            CreateMap<user, CreateUserCommand>().ReverseMap();
            CreateMap<user, EditUserCommand>().ReverseMap();
        }
    }
}
