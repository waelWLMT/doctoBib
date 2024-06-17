using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class RendezVousProfile : Profile
    {
        public RendezVousProfile()
        {
            CreateMap<RendezVous, RendezVousReadDto>();
        }
    }
}
