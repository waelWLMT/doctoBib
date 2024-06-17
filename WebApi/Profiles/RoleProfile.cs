using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleReadDto>();
        }
    }
}
