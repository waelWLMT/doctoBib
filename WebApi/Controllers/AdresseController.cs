using AutoMapper;
using BLL.Services.ReadServices;
using Core.Dtos;
using Core.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdresseController : ControllerBase
    {
        private readonly IAdresseReadService _adresseReadService;
        private IMapper _mapper;
        
        public AdresseController(IAdresseReadService adresseReadService, IMapper mapper)
        {
            _adresseReadService = adresseReadService;
            _mapper = mapper;            
        }


        [HttpGet]
        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
