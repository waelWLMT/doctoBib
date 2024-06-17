using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class SpecialiteProfile : Profile
    {
        public SpecialiteProfile()
        {
            CreateMap<Specialite, SpecialiteReadDto>();
        }
    }
}
