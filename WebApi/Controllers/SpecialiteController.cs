using AutoMapper;
using BLL.UseCases.Queries.SepcialiteQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialiteController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public SpecialiteController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

       
        [HttpGet("GetAllSpecialite")]
        public async Task<List<SpecialiteReadDto>> GetAllSpecialite()
        {
            var request = new GetAllSpecialiteRequest();
            var specialites = await _mediator.Send(request);

            var result = _mapper.Map<List<SpecialiteReadDto>>(specialites);

            return result;
        }
    }
}
