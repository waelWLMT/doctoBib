using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class AdresseProfile : Profile
    {
        public AdresseProfile()
        {
            CreateMap<Adresse, AdresseReadDto>();
        }
    }
}
