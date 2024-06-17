using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class MotifProfile : Profile
    {
        public MotifProfile()
        {
            CreateMap<Motif, MotifReadDto>();
        }
    }
}
