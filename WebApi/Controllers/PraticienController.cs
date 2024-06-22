using AutoMapper;
using BLL.UseCases.Queries.PraticienQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PraticienController : ControllerBase
    {
        private readonly IMediator _mediator;
        private IMapper _mapper;

        public PraticienController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("GetAllPraticien")]
        public async Task<List<PraticienReadDto>> GetAllPraticien()
        {
            var praticiens = await _mediator.Send(new GelAllPraticienRequest());
            var result = _mapper.Map<List<PraticienReadDto>>(praticiens);

            return result;
        }
    }


}
