using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class VilleProfile : Profile
    {
        public VilleProfile()
        {
            CreateMap<Ville, VilleReadDto>();
        }
    }
}
