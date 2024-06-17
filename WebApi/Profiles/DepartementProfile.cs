using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class DepartementProfile : Profile
    {
        public DepartementProfile()
        {
            CreateMap<Departement, DepartementReadDto>();
        }
    }
}
