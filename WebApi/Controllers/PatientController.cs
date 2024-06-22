using AutoMapper;
using BLL.UseCases.Queries.PatientQueries;
using BLL.UseCases.Queries.PraticienQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IMediator _mediator;
        private IMapper _mapper;

        public PatientController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("GetAllPatient")]
        public async Task<List<PatientReadDto>> GetAllPatien()
        {
            var patients = await _mediator.Send(new GetAllPatientRequest());
            var result = _mapper.Map<List<PatientReadDto>>(patients);

            return result;
        }


    }
}
