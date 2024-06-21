using AutoMapper;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RendezVousController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RendezVousController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("GetAllRendezVous")]
        public List<RendezVousReadDto> GetAllRendezVous()
        {
            return new List<RendezVousReadDto>();
        }

        [HttpGet]
        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
