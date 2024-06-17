using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            CreateMap<Menu, MenuReadDto>();
        }
    }
}
