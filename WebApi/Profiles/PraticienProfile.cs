using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class PraticienProfile : Profile
    {
        public PraticienProfile()
        {
            CreateMap<Praticien, PraticienReadDto>();
        }
    }
}
